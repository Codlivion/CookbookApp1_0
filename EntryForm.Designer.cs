namespace CookbookApp1_0
{
    partial class EntryForm
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
            this.addRecipeBtn = new System.Windows.Forms.Button();
            this.addStepBtn = new System.Windows.Forms.Button();
            this.stepBox = new System.Windows.Forms.TextBox();
            this.ingredientBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.ingredientLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.prepLabel = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.prepBox = new System.Windows.Forms.NumericUpDown();
            this.addIngredientBtn = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainLayout.ColumnCount = 6;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.Controls.Add(this.addRecipeBtn, 2, 8);
            this.mainLayout.Controls.Add(this.addStepBtn, 4, 6);
            this.mainLayout.Controls.Add(this.stepBox, 1, 5);
            this.mainLayout.Controls.Add(this.ingredientBox, 3, 4);
            this.mainLayout.Controls.Add(this.unitBox, 2, 4);
            this.mainLayout.Controls.Add(this.quantityBox, 1, 4);
            this.mainLayout.Controls.Add(this.ingredientLabel, 3, 3);
            this.mainLayout.Controls.Add(this.unitLabel, 2, 3);
            this.mainLayout.Controls.Add(this.quantityLabel, 1, 3);
            this.mainLayout.Controls.Add(this.prepLabel, 2, 2);
            this.mainLayout.Controls.Add(this.courseBox, 3, 1);
            this.mainLayout.Controls.Add(this.courseLabel, 2, 1);
            this.mainLayout.Controls.Add(this.nameLabel, 2, 0);
            this.mainLayout.Controls.Add(this.nameBox, 3, 0);
            this.mainLayout.Controls.Add(this.prepBox, 3, 2);
            this.mainLayout.Controls.Add(this.addIngredientBtn, 4, 3);
            this.mainLayout.Controls.Add(this.cancelButton, 2, 9);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 10;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainLayout.Size = new System.Drawing.Size(800, 600);
            this.mainLayout.TabIndex = 0;
            // 
            // addRecipeBtn
            // 
            this.addRecipeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLayout.SetColumnSpan(this.addRecipeBtn, 2);
            this.addRecipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addRecipeBtn.Location = new System.Drawing.Point(323, 490);
            this.addRecipeBtn.Name = "addRecipeBtn";
            this.addRecipeBtn.Size = new System.Drawing.Size(154, 40);
            this.addRecipeBtn.TabIndex = 15;
            this.addRecipeBtn.Text = "Add Recipe";
            this.addRecipeBtn.UseVisualStyleBackColor = true;
            this.addRecipeBtn.Click += new System.EventHandler(this.AddRecipe);
            // 
            // addStepBtn
            // 
            this.addStepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addStepBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addStepBtn.Location = new System.Drawing.Point(563, 370);
            this.addStepBtn.Name = "addStepBtn";
            this.addStepBtn.Size = new System.Drawing.Size(154, 40);
            this.addStepBtn.TabIndex = 14;
            this.addStepBtn.Text = "Add Step";
            this.addStepBtn.UseVisualStyleBackColor = true;
            this.addStepBtn.Click += new System.EventHandler(this.AddStep);
            // 
            // stepBox
            // 
            this.stepBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayout.SetColumnSpan(this.stepBox, 3);
            this.stepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stepBox.Location = new System.Drawing.Point(83, 303);
            this.stepBox.MaxLength = 1024;
            this.stepBox.Multiline = true;
            this.stepBox.Name = "stepBox";
            this.mainLayout.SetRowSpan(this.stepBox, 3);
            this.stepBox.Size = new System.Drawing.Size(474, 174);
            this.stepBox.TabIndex = 13;
            // 
            // ingredientBox
            // 
            this.ingredientBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ingredientBox.Location = new System.Drawing.Point(403, 243);
            this.ingredientBox.MaxLength = 32;
            this.ingredientBox.Name = "ingredientBox";
            this.ingredientBox.Size = new System.Drawing.Size(154, 26);
            this.ingredientBox.TabIndex = 11;
            this.ingredientBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitBox
            // 
            this.unitBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unitBox.Location = new System.Drawing.Point(243, 243);
            this.unitBox.MaxLength = 32;
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(154, 26);
            this.unitBox.TabIndex = 10;
            this.unitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityBox
            // 
            this.quantityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantityBox.Location = new System.Drawing.Point(83, 243);
            this.quantityBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(154, 26);
            this.quantityBox.TabIndex = 9;
            this.quantityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ingredientLabel
            // 
            this.ingredientLabel.AutoSize = true;
            this.ingredientLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ingredientLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ingredientLabel.Location = new System.Drawing.Point(403, 183);
            this.ingredientLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ingredientLabel.Name = "ingredientLabel";
            this.ingredientLabel.Size = new System.Drawing.Size(154, 54);
            this.ingredientLabel.TabIndex = 8;
            this.ingredientLabel.Text = "Ingredient";
            this.ingredientLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.unitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unitLabel.Location = new System.Drawing.Point(243, 183);
            this.unitLabel.Margin = new System.Windows.Forms.Padding(3);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(154, 54);
            this.unitLabel.TabIndex = 7;
            this.unitLabel.Text = "Unit";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quantityLabel.Location = new System.Drawing.Point(83, 183);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(154, 54);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // prepLabel
            // 
            this.prepLabel.AutoSize = true;
            this.prepLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prepLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prepLabel.Location = new System.Drawing.Point(243, 123);
            this.prepLabel.Margin = new System.Windows.Forms.Padding(3);
            this.prepLabel.Name = "prepLabel";
            this.prepLabel.Size = new System.Drawing.Size(154, 54);
            this.prepLabel.TabIndex = 4;
            this.prepLabel.Text = "Preparation Time:";
            this.prepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // courseBox
            // 
            this.courseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.courseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.courseBox.Location = new System.Drawing.Point(403, 77);
            this.courseBox.MaxLength = 32;
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(154, 26);
            this.courseBox.TabIndex = 3;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.courseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.courseLabel.Location = new System.Drawing.Point(243, 63);
            this.courseLabel.Margin = new System.Windows.Forms.Padding(3);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(154, 54);
            this.courseLabel.TabIndex = 2;
            this.courseLabel.Text = "Course:";
            this.courseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(243, 3);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(154, 54);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameBox.Location = new System.Drawing.Point(403, 17);
            this.nameBox.MaxLength = 32;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(154, 26);
            this.nameBox.TabIndex = 1;
            // 
            // prepBox
            // 
            this.prepBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prepBox.Location = new System.Drawing.Point(403, 137);
            this.prepBox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.prepBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prepBox.Name = "prepBox";
            this.prepBox.Size = new System.Drawing.Size(154, 26);
            this.prepBox.TabIndex = 5;
            this.prepBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addIngredientBtn
            // 
            this.addIngredientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addIngredientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addIngredientBtn.Location = new System.Drawing.Point(563, 220);
            this.addIngredientBtn.Name = "addIngredientBtn";
            this.mainLayout.SetRowSpan(this.addIngredientBtn, 2);
            this.addIngredientBtn.Size = new System.Drawing.Size(154, 40);
            this.addIngredientBtn.TabIndex = 12;
            this.addIngredientBtn.Text = "Add Ingredient";
            this.addIngredientBtn.UseVisualStyleBackColor = true;
            this.addIngredientBtn.Click += new System.EventHandler(this.AddIngredient);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLayout.SetColumnSpan(this.cancelButton, 2);
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.Location = new System.Drawing.Point(323, 550);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 40);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelForm);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainLayout);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label prepLabel;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.NumericUpDown prepBox;
        private System.Windows.Forms.Label ingredientLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox ingredientBox;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Button addStepBtn;
        private System.Windows.Forms.TextBox stepBox;
        private System.Windows.Forms.Button addIngredientBtn;
        private System.Windows.Forms.Button addRecipeBtn;
        private System.Windows.Forms.Button cancelButton;
    }
}