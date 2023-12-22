using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CookbookApp1_0
{
    public partial class EntryForm : Form
    {
        MainForm mainForm;
        List<Ingredient> ingredients = new List<Ingredient>();
        List<string> steps = new List<string>();

        public EntryForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        public void AddIngredient(object sender, EventArgs e)
        {
            if (ingredientBox.Text == "")
            {
                MessageBox.Show("No ingredient name was specified!");
                return;
            }
            ingredients.Add(new Ingredient(ingredientBox.Text, (int)quantityBox.Value, unitBox.Text));
            ingredientBox.Text = "";
            quantityBox.Value = 1;
            unitBox.Text = "";
        }

        public void AddStep(object sender, EventArgs e)
        {
            if (stepBox.Text == "")
            {
                MessageBox.Show("Please type in the current step for the recipe!");
                return;
            }
            steps.Add(stepBox.Text);
            stepBox.Text = "";
        }

        public void AddRecipe(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("No recipe name was specified!");
                return;
            }
            if (courseBox.Text == "") courseBox.Text = "Other";
            Dish dish = new Dish(nameBox.Text, courseBox.Text, (int)prepBox.Value);
            dish.Ingredients = new List<Ingredient>(ingredients);
            dish.Steps = new List<string>(steps);
            mainForm.AddToDatabase(dish);
            Close();
        }

        public void CancelForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}