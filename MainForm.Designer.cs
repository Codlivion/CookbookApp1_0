namespace CookbookApp1_0
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.midPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.Controls.Add(this.ingredientsLabel, 2, 0);
            this.mainLayout.Controls.Add(this.nameLabel, 1, 0);
            this.mainLayout.Controls.Add(this.rightPanel, 2, 1);
            this.mainLayout.Controls.Add(this.midPanel, 1, 1);
            this.mainLayout.Controls.Add(this.leftPanel, 0, 1);
            this.mainLayout.Controls.Add(this.recipesLabel, 0, 0);
            this.mainLayout.Controls.Add(this.addButton, 1, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.mainLayout.Size = new System.Drawing.Size(800, 600);
            this.mainLayout.TabIndex = 0;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ingredientsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ingredientsLabel.Location = new System.Drawing.Point(643, 0);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(154, 48);
            this.ingredientsLabel.TabIndex = 5;
            this.ingredientsLabel.Text = "Ingredients";
            this.ingredientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(163, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(474, 48);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Recipe Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(643, 51);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(154, 486);
            this.rightPanel.TabIndex = 2;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.IngredientPanelDraw);
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(163, 51);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(474, 486);
            this.midPanel.TabIndex = 1;
            this.midPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RecipePanelDraw);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 51);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(154, 486);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ListPanelDraw);
            this.leftPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListPanelClick);
            // 
            // recipesLabel
            // 
            this.recipesLabel.AutoSize = true;
            this.recipesLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.recipesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipesLabel.Location = new System.Drawing.Point(3, 0);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(154, 48);
            this.recipesLabel.TabIndex = 3;
            this.recipesLabel.Text = "Recipes";
            this.recipesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(163, 543);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(474, 54);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "New Recipe";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.NewRecipeButton);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainLayout);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label recipesLabel;
        private System.Windows.Forms.Button addButton;
    }
}

