using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CookbookApp1_0
{
    public partial class MainForm : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RecipeList.mdf;Integrated Security=True";

        List<Dish> dishes;
        int currentDish = 0;
        int charSize = 8;
        int offset = 5;
        Point boxSize = new Point(154 , 30);

        int listPageNum = 0;
        int listPageStart => listPageNum * pageLimit;
        int totalListPages => dishes.Count % pageLimit == 0 ? (dishes.Count / pageLimit) - 1 : dishes.Count / pageLimit;

        int sScrollPos = 0;
        int iScrollPos = 0;
        int pageLimit = 16;
        int lineLimit => midPanel.Size.Width / charSize;
        int sLineCount => BreakSteps(dishes[currentDish].Steps).Count;
        int iLineCount => dishes[currentDish].Ingredients.Count;

        Font stdFont = new Font("Arial", 12);

        public MainForm()
        {
            InitializeComponent();
            dishes = new List<Dish>();
            ReadFromDatabase();
            if (dishes.Count == 0) dishes = InitialList();
            midPanel.MouseWheel += RecipePanelWheel;
            rightPanel.MouseWheel += IngredientPanelWheel;
        }

        public void NewRecipeButton(object sender, EventArgs e)
        {
            EntryForm entryForm = new EntryForm(this);
            entryForm.ShowDialog();
        }

        public List<string> BreakSteps(List<string> steps)
        {
            List<string> result = new List<string>();
            for (int stepNum = 0; stepNum < steps.Count; stepNum++)
            {
                int n = stepNum + 1;
                int lineStart = 0;
                string step = $"Step {n}: {steps[stepNum]}";
                while (lineStart + lineLimit < step.Length)
                {
                    int lineEnd = lineStart + lineLimit;
                    while (lineEnd > lineStart && !char.IsWhiteSpace(step[lineEnd]))
                    {
                        lineEnd--;
                    }
                    if (lineEnd == lineStart) lineEnd += lineLimit;
                    string line = step.Substring(lineStart, lineEnd - lineStart);
                    lineStart = lineEnd + 1;
                    result.Add(line);
                }
                string last = step.Substring(lineStart);
                result.Add(last);
            }
            return result;
        }

        public void UpdateDishes(bool readDatabase = false)
        {
            if (readDatabase) ReadFromDatabase();
            sScrollPos = 0;
            iScrollPos = 0;
            leftPanel.Invalidate();
            midPanel.Invalidate();
            rightPanel.Invalidate();
        }

        public void ListPanelClick(object sender, MouseEventArgs e)
        {
            if (e.Y > boxSize.Y * pageLimit)
            {
                if (e.X < boxSize.X / 2)
                {
                    if (listPageNum > 0) listPageNum--;
                }
                else
                {
                    if (listPageNum < totalListPages) listPageNum++;
                }
            }
            else
            {
                int i = listPageStart + (e.Y / boxSize.Y);
                if (i < dishes.Count) currentDish = i;
            }
            UpdateDishes();
        }

        public void RecipePanelWheel(object sender, MouseEventArgs e)
        {
            sScrollPos -= e.Delta > 0 ? 1 : e.Delta < 0 ? -1 : 0;
            if (sScrollPos < 0) sScrollPos = 0;
            if (sLineCount >= pageLimit)
            {
                if (sScrollPos > sLineCount - pageLimit) sScrollPos = sLineCount - pageLimit;
            }
            else sScrollPos = 0;
            midPanel.Invalidate();
        }

        public void IngredientPanelWheel(object sender, MouseEventArgs e)
        {
            iScrollPos -= e.Delta > 0 ? 1 : e.Delta < 0 ? -1 : 0;
            if (iScrollPos < 0) iScrollPos = 0;
            if (iLineCount >= pageLimit)
            {
                if (iScrollPos > iLineCount - pageLimit) iScrollPos = iLineCount - pageLimit;
            }
            else iScrollPos = 0;
            rightPanel.Invalidate();
        }

        public void ListPanelDraw(object sender, PaintEventArgs e)
        {
            int halfWidth = boxSize.X / 2;
            int listHeight = boxSize.Y * pageLimit;
            int endIndex = Math.Min(listPageStart + pageLimit, dishes.Count);
            for (int i = listPageStart; i < endIndex; i++)
            {
                int iPos = (i - listPageStart);
                int namePos = halfWidth - (charSize * dishes[i].Name.Length / 2);
                Rectangle rect = new Rectangle(0, iPos * boxSize.Y, boxSize.X, boxSize.Y);
                e.Graphics.DrawRectangle(Pens.Gray, rect);
                e.Graphics.DrawString(dishes[i].Name, stdFont, Brushes.Black, namePos, iPos * boxSize.Y + offset);
            }
            Rectangle leftPage = new Rectangle(0, listHeight, halfWidth - 1, leftPanel.Height - listHeight - 1);
            Rectangle rightPage = new Rectangle(halfWidth, listHeight, halfWidth - 1, leftPanel.Height - listHeight - 1);
            e.Graphics.DrawRectangle(Pens.Green, leftPage);
            e.Graphics.DrawRectangle(Pens.Green, rightPage);
            e.Graphics.DrawString("<", stdFont, Brushes.Black, (halfWidth / 2) - offset, listHeight + offset);
            e.Graphics.DrawString(">", stdFont, Brushes.Black, (halfWidth / 2) - offset + halfWidth, listHeight + offset);
        }

        public void RecipePanelDraw(object sender, PaintEventArgs e)
        {
            if (dishes.Count == 0) return;

            nameLabel.Text = dishes[currentDish].Name;
            int endIndex = Math.Min(sScrollPos + pageLimit, sLineCount);
            List<string> lines = BreakSteps(dishes[currentDish].Steps);
            for (int i = sScrollPos; i < endIndex; i++)
            {
                int iPos = i - sScrollPos;
                e.Graphics.DrawString(lines[i], stdFont, Brushes.Black, offset, iPos * boxSize.Y + offset);
            }
        }

        public void IngredientPanelDraw(object sender, PaintEventArgs e)
        {
            if (dishes.Count == 0) return;

            int endIndex = Math.Min(iScrollPos + pageLimit, iLineCount);
            for (int i = iScrollPos; i < endIndex; i++)
            {
                int iPos = i - iScrollPos;
                Ingredient ingredient = dishes[currentDish].Ingredients[i];
                Rectangle rect = new Rectangle(0, iPos * boxSize.Y, boxSize.X, boxSize.Y);
                e.Graphics.DrawRectangle(Pens.Gray, rect);
                string s = $"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}";
                e.Graphics.DrawString(s, stdFont, Brushes.Black, offset, iPos * boxSize.Y + offset);
            }
        }

        public void AddToDatabase(Dish dish)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertDish = "INSERT INTO Dish (Name, Course, PrepTime) VALUES (@Name, @Course, @PrepTime);" +
                    "SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(insertDish, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", dish.Name);
                    command.Parameters.AddWithValue("@Course", dish.Course);
                    command.Parameters.AddWithValue("@PrepTime", dish.PrepTime);
                    dish.ID = Convert.ToInt32(command.ExecuteScalar());
                }

                string insertIngredient = "INSERT INTO Ingredient (DishID, Name, Quantity, Unit)" +
                        "Values (@DishID, @Name, @Quantity, @Unit)";
                using (SqlCommand command = new SqlCommand(@insertIngredient, connection))
                {
                    for (int i = 0; i < dish.Ingredients.Count; i++)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@DishID", dish.ID);
                        command.Parameters.AddWithValue("@Name", dish.Ingredients[i].Name);
                        command.Parameters.AddWithValue("@Quantity", dish.Ingredients[i].Quantity);
                        command.Parameters.AddWithValue("@Unit", dish.Ingredients[i].Unit);
                        command.ExecuteNonQuery();
                    }
                }

                string insertStep = "INSERT INTO Step (DishID, Step) Values (@DishID, @Step)";
                using (SqlCommand command = new SqlCommand(@insertStep, connection))
                {
                    for (int i = 0; i < dish.Steps.Count; i++)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@DishID", dish.ID);
                        command.Parameters.AddWithValue("@Step", dish.Steps[i]);
                        command.ExecuteNonQuery();
                    }
                }
            }
            UpdateDishes(true);
        }

        public void ReadFromDatabase()
        {
            dishes.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Dish";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int dishID = reader.GetInt32(0);
                            string dishName = reader.GetString(1);
                            string course = reader.GetString(2);
                            int prepTime = reader.GetInt32(3);
                            Dish dish = new Dish(dishID, dishName, course, prepTime);
                            dishes.Add(dish);
                        }
                    }
                }
                string ingredientQuery = "SELECT * FROM Ingredient WHERE DishID = @DishID";
                using (SqlCommand command = new SqlCommand(ingredientQuery, connection))
                {
                    foreach (Dish dish in dishes)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@DishID", dish.ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ingredientName = reader.GetString(2);
                                int quantity = reader.GetInt32(3);
                                string unit = reader.GetString(4);
                                dish.Ingredients.Add(new Ingredient(ingredientName, quantity, unit));
                            }
                        }
                    }
                    
                }
                string stepQuery = "SELECT * FROM Step WHERE DishID = @DishID";
                using (SqlCommand command = new SqlCommand(stepQuery, connection))
                {
                    foreach (Dish dish in dishes)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@DishID", dish.ID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string step = reader.GetString(2);
                                dish.Steps.Add(step);
                            }
                        }
                    }
                }
            }
            currentDish = 0;
        }

        public void DeleteFromDatabase(Dish dish) //Not implemented yet
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string deleteSteps = "DELETE FROM Step WHERE DishID = @ID";
                        using (SqlCommand command = new SqlCommand(deleteSteps, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ID", dish.ID);
                            command.ExecuteNonQuery();
                        }
                        string deleteIngredients = "DELETE FROM Ingredient WHERE DishID = @ID";
                        using (SqlCommand command = new SqlCommand(deleteIngredients, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ID", dish.ID);
                            command.ExecuteNonQuery();
                        }
                        string deleteDish = "DELETE FROM Dish WHERE ID = @ID";
                        using (SqlCommand command = new SqlCommand(deleteDish, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ID", dish.ID);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }

    public class Dish
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int PrepTime { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public Dish(string name, string course, int time)
        {
            Name = name;
            Course = course;
            PrepTime = time;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }

        public Dish(int id, string name, string course, int time) : this(name, course, time) { ID = id; }
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient() { }

        public Ingredient(string name, int quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}