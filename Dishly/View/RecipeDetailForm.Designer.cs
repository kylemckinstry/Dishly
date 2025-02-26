namespace Dishly.View
{
    partial class RecipeDetailForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            categoryLabel = new Label();
            cuisineLabel = new Label();
            panel1 = new Panel();
            panel8 = new Panel();
            categoryText = new Label();
            panel7 = new Panel();
            tagsText = new Label();
            panel6 = new Panel();
            panel5 = new Panel();
            tagsLabel = new Label();
            panel4 = new Panel();
            cuisineText = new Label();
            panel3 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            cookingInstructionsButton = new Button();
            favoriteButton = new Button();
            backButton = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ingredientsListBox = new ListBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.FlatStyle = FlatStyle.System;
            categoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            categoryLabel.Location = new Point(1, 0);
            categoryLabel.Margin = new Padding(2, 0, 2, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(80, 21);
            categoryLabel.TabIndex = 37;
            categoryLabel.Text = "Category";
            // 
            // cuisineLabel
            // 
            cuisineLabel.AutoSize = true;
            cuisineLabel.FlatStyle = FlatStyle.System;
            cuisineLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cuisineLabel.Location = new Point(2, 0);
            cuisineLabel.Margin = new Padding(2, 0, 2, 0);
            cuisineLabel.Name = "cuisineLabel";
            cuisineLabel.Size = new Size(66, 21);
            cuisineLabel.TabIndex = 39;
            cuisineLabel.Text = "Cuisine";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(284, 44);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 290);
            panel1.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.Controls.Add(categoryText);
            panel8.Location = new Point(108, 204);
            panel8.Name = "panel8";
            panel8.Size = new Size(96, 60);
            panel8.TabIndex = 44;
            // 
            // categoryText
            // 
            categoryText.AutoSize = true;
            categoryText.Location = new Point(1, 6);
            categoryText.Margin = new Padding(2, 0, 2, 0);
            categoryText.Name = "categoryText";
            categoryText.Size = new Size(69, 15);
            categoryText.TabIndex = 38;
            categoryText.Text = "<category>";
            // 
            // panel7
            // 
            panel7.Controls.Add(tagsText);
            panel7.Location = new Point(108, 128);
            panel7.Name = "panel7";
            panel7.Size = new Size(96, 79);
            panel7.TabIndex = 43;
            // 
            // tagsText
            // 
            tagsText.AutoSize = true;
            tagsText.Location = new Point(2, 6);
            tagsText.Margin = new Padding(2, 0, 2, 0);
            tagsText.Name = "tagsText";
            tagsText.Size = new Size(45, 15);
            tagsText.TabIndex = 36;
            tagsText.Text = "<tags>";
            // 
            // panel6
            // 
            panel6.Controls.Add(categoryLabel);
            panel6.Location = new Point(22, 204);
            panel6.Name = "panel6";
            panel6.Size = new Size(81, 60);
            panel6.TabIndex = 43;
            // 
            // panel5
            // 
            panel5.Controls.Add(tagsLabel);
            panel5.Location = new Point(22, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(81, 60);
            panel5.TabIndex = 42;
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.FlatStyle = FlatStyle.System;
            tagsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tagsLabel.Location = new Point(0, 0);
            tagsLabel.Margin = new Padding(2, 0, 2, 0);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new Size(44, 21);
            tagsLabel.TabIndex = 35;
            tagsLabel.Text = "Tags";
            // 
            // panel4
            // 
            panel4.Controls.Add(cuisineText);
            panel4.Location = new Point(108, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(96, 60);
            panel4.TabIndex = 42;
            // 
            // cuisineText
            // 
            cuisineText.AutoSize = true;
            cuisineText.Location = new Point(2, 6);
            cuisineText.Margin = new Padding(2, 0, 2, 0);
            cuisineText.Name = "cuisineText";
            cuisineText.Size = new Size(69, 15);
            cuisineText.TabIndex = 40;
            cuisineText.Text = "<category>";
            // 
            // panel3
            // 
            panel3.Controls.Add(cuisineLabel);
            panel3.Location = new Point(21, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(81, 60);
            panel3.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(56, 163, 165);
            label1.Location = new Point(55, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "Information";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(56, 163, 165);
            textBox1.Location = new Point(10, 12);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(774, 28);
            textBox1.TabIndex = 11;
            // 
            // cookingInstructionsButton
            // 
            cookingInstructionsButton.BackColor = Color.FromArgb(87, 204, 153);
            cookingInstructionsButton.Font = new Font("Segoe UI", 10F);
            cookingInstructionsButton.ForeColor = SystemColors.Control;
            cookingInstructionsButton.Location = new Point(351, 337);
            cookingInstructionsButton.Margin = new Padding(2);
            cookingInstructionsButton.Name = "cookingInstructionsButton";
            cookingInstructionsButton.Size = new Size(433, 52);
            cookingInstructionsButton.TabIndex = 10;
            cookingInstructionsButton.Text = "Cooking Instructions";
            cookingInstructionsButton.UseVisualStyleBackColor = false;
            cookingInstructionsButton.Click += cookingInstructionsButton_Click;
            // 
            // favoriteButton
            // 
            favoriteButton.BackColor = Color.FromArgb(56, 163, 165);
            favoriteButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            favoriteButton.ForeColor = SystemColors.Control;
            favoriteButton.Location = new Point(129, 338);
            favoriteButton.Margin = new Padding(2);
            favoriteButton.Name = "favoriteButton";
            favoriteButton.Size = new Size(218, 52);
            favoriteButton.TabIndex = 9;
            favoriteButton.Text = "Favorites";
            favoriteButton.UseVisualStyleBackColor = false;
            favoriteButton.Click += favoriteButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Salmon;
            backButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            backButton.ForeColor = SystemColors.Control;
            backButton.Location = new Point(10, 338);
            backButton.Margin = new Padding(2);
            backButton.Name = "backButton";
            backButton.Size = new Size(115, 53);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 44);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 290);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ingredientsListBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(510, 44);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 289);
            panel2.TabIndex = 13;
            // 
            // ingredientsListBox
            // 
            ingredientsListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingredientsListBox.FormattingEnabled = true;
            ingredientsListBox.ItemHeight = 21;
            ingredientsListBox.Items.AddRange(new object[] { "<ingredient #1>", "<ingredient #2>", "<ingredient #3>" });
            ingredientsListBox.Location = new Point(18, 61);
            ingredientsListBox.Margin = new Padding(2, 1, 2, 1);
            ingredientsListBox.Name = "ingredientsListBox";
            ingredientsListBox.Size = new Size(238, 214);
            ingredientsListBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(87, 204, 153);
            label2.Location = new Point(79, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 0;
            label2.Text = "Ingredients";
            // 
            // RecipeDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(cookingInstructionsButton);
            Controls.Add(favoriteButton);
            Controls.Add(backButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "RecipeDetailForm";
            Size = new Size(800, 400);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button cookingInstructionsButton;
        private Button favoriteButton;
        private Button backButton;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label TagsLabel;
        private Label cuisineText;
        private Label categoryText;
        private Label categoryLabel;
        private Label cuisineLabel;
        private ListBox ingredientsListBox;
        private Label tagsLabel;
        private Label tagsText;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
    }
}
