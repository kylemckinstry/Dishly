namespace Dishly
{
    partial class CookingMethod
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
            panel2 = new Panel();
            RecipeName = new TextBox();
            removeFromWeekButton = new Button();
            myWeekComboBox = new ComboBox();
            addToWeekButton = new Button();
            panel7 = new Panel();
            cookingInstructionTextBox = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            ingredientsListBox = new ListBox();
            panel5 = new Panel();
            cuisineText = new Label();
            cuisineLabel = new Label();
            categoryText = new Label();
            categoryLabel = new Label();
            tagsText = new Label();
            tagsLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            browserButton = new Button();
            MyWeekHeader = new Label();
            myWeekButton = new Button();
            headerPanel = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(RecipeName);
            panel2.Controls.Add(removeFromWeekButton);
            panel2.Controls.Add(myWeekComboBox);
            panel2.Controls.Add(addToWeekButton);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(260, 143);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 714);
            panel2.TabIndex = 2;
            // 
            // RecipeName
            // 
            RecipeName.BackColor = Color.WhiteSmoke;
            RecipeName.BorderStyle = BorderStyle.None;
            RecipeName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecipeName.ForeColor = Color.FromArgb(56, 163, 165);
            RecipeName.Location = new Point(15, 13);
            RecipeName.Margin = new Padding(2);
            RecipeName.Name = "RecipeName";
            RecipeName.Size = new Size(301, 26);
            RecipeName.TabIndex = 48;
            RecipeName.TextChanged += RecipeName_TextChanged;
            // 
            // removeFromWeekButton
            // 
            removeFromWeekButton.BackColor = Color.Salmon;
            removeFromWeekButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            removeFromWeekButton.ForeColor = SystemColors.Control;
            removeFromWeekButton.Location = new Point(147, 290);
            removeFromWeekButton.Margin = new Padding(1);
            removeFromWeekButton.Name = "removeFromWeekButton";
            removeFromWeekButton.Size = new Size(169, 41);
            removeFromWeekButton.TabIndex = 11;
            removeFromWeekButton.Text = "Remove from Week";
            removeFromWeekButton.UseVisualStyleBackColor = false;
            removeFromWeekButton.Click += removeFromWeekButton_Click;
            // 
            // myWeekComboBox
            // 
            myWeekComboBox.FormattingEnabled = true;
            myWeekComboBox.Location = new Point(15, 263);
            myWeekComboBox.Name = "myWeekComboBox";
            myWeekComboBox.Size = new Size(301, 23);
            myWeekComboBox.TabIndex = 11;
            // 
            // addToWeekButton
            // 
            addToWeekButton.BackColor = Color.FromArgb(87, 204, 153);
            addToWeekButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToWeekButton.ForeColor = SystemColors.Control;
            addToWeekButton.Location = new Point(15, 290);
            addToWeekButton.Margin = new Padding(1);
            addToWeekButton.Name = "addToWeekButton";
            addToWeekButton.Size = new Size(121, 41);
            addToWeekButton.TabIndex = 6;
            addToWeekButton.Text = "Add to Week";
            addToWeekButton.UseVisualStyleBackColor = false;
            addToWeekButton.Click += addToWeekButton_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(cookingInstructionTextBox);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(329, 13);
            panel7.Margin = new Padding(1);
            panel7.Name = "panel7";
            panel7.Size = new Size(337, 675);
            panel7.TabIndex = 5;
            // 
            // cookingInstructionTextBox
            // 
            cookingInstructionTextBox.BackColor = Color.White;
            cookingInstructionTextBox.Location = new Point(10, 53);
            cookingInstructionTextBox.Margin = new Padding(1, 0, 1, 0);
            cookingInstructionTextBox.Multiline = true;
            cookingInstructionTextBox.Name = "cookingInstructionTextBox";
            cookingInstructionTextBox.ReadOnly = true;
            cookingInstructionTextBox.ScrollBars = ScrollBars.Vertical;
            cookingInstructionTextBox.Size = new Size(316, 612);
            cookingInstructionTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 129, 51);
            label3.Location = new Point(10, 8);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 1;
            label3.Text = "Method";
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(ingredientsListBox);
            panel6.Location = new Point(15, 524);
            panel6.Margin = new Padding(1);
            panel6.Name = "panel6";
            panel6.Size = new Size(301, 164);
            panel6.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(87, 204, 153);
            label2.Location = new Point(11, 13);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 2;
            label2.Text = "Ingredients";
            // 
            // ingredientsListBox
            // 
            ingredientsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingredientsListBox.FormattingEnabled = true;
            ingredientsListBox.ItemHeight = 15;
            ingredientsListBox.Items.AddRange(new object[] { "<ingredient #1>", "<ingredient #2>", "<ingredient #3>" });
            ingredientsListBox.Location = new Point(14, 60);
            ingredientsListBox.Margin = new Padding(1);
            ingredientsListBox.Name = "ingredientsListBox";
            ingredientsListBox.Size = new Size(271, 94);
            ingredientsListBox.TabIndex = 41;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(cuisineText);
            panel5.Controls.Add(cuisineLabel);
            panel5.Controls.Add(categoryText);
            panel5.Controls.Add(categoryLabel);
            panel5.Controls.Add(tagsText);
            panel5.Controls.Add(tagsLabel);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(15, 343);
            panel5.Margin = new Padding(1);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 170);
            panel5.TabIndex = 3;
            // 
            // cuisineText
            // 
            cuisineText.AutoSize = true;
            cuisineText.Location = new Point(11, 93);
            cuisineText.Margin = new Padding(1, 0, 1, 0);
            cuisineText.Name = "cuisineText";
            cuisineText.Size = new Size(69, 15);
            cuisineText.TabIndex = 47;
            cuisineText.Text = "<category>";
            // 
            // cuisineLabel
            // 
            cuisineLabel.AutoSize = true;
            cuisineLabel.FlatStyle = FlatStyle.System;
            cuisineLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cuisineLabel.Location = new Point(14, 58);
            cuisineLabel.Margin = new Padding(1, 0, 1, 0);
            cuisineLabel.Name = "cuisineLabel";
            cuisineLabel.Size = new Size(66, 21);
            cuisineLabel.TabIndex = 46;
            cuisineLabel.Text = "Cuisine";
            // 
            // categoryText
            // 
            categoryText.AutoSize = true;
            categoryText.Location = new Point(109, 93);
            categoryText.Margin = new Padding(1, 0, 1, 0);
            categoryText.Name = "categoryText";
            categoryText.Size = new Size(69, 15);
            categoryText.TabIndex = 45;
            categoryText.Text = "<category>";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.FlatStyle = FlatStyle.System;
            categoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            categoryLabel.Location = new Point(109, 58);
            categoryLabel.Margin = new Padding(1, 0, 1, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(80, 21);
            categoryLabel.TabIndex = 44;
            categoryLabel.Text = "Category";
            // 
            // tagsText
            // 
            tagsText.AutoSize = true;
            tagsText.Location = new Point(222, 93);
            tagsText.Margin = new Padding(1, 0, 1, 0);
            tagsText.Name = "tagsText";
            tagsText.Size = new Size(45, 15);
            tagsText.TabIndex = 43;
            tagsText.Text = "<tags>";
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.FlatStyle = FlatStyle.System;
            tagsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tagsLabel.Location = new Point(223, 58);
            tagsLabel.Margin = new Padding(1, 0, 1, 0);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new Size(44, 21);
            tagsLabel.TabIndex = 42;
            tagsLabel.Text = "Tags";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(56, 163, 165);
            label1.Location = new Point(11, 12);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 53);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 195);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // browserButton
            // 
            browserButton.BackColor = Color.FromArgb(255, 129, 51);
            browserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browserButton.ForeColor = SystemColors.Control;
            browserButton.Location = new Point(2, 2);
            browserButton.Margin = new Padding(2);
            browserButton.Name = "browserButton";
            browserButton.Size = new Size(80, 37);
            browserButton.TabIndex = 9;
            browserButton.Text = "Browser";
            browserButton.UseVisualStyleBackColor = false;
            browserButton.Click += browserButton_Click;
            // 
            // MyWeekHeader
            // 
            MyWeekHeader.Anchor = AnchorStyles.Top;
            MyWeekHeader.AutoSize = true;
            MyWeekHeader.BackColor = Color.Transparent;
            MyWeekHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MyWeekHeader.ForeColor = SystemColors.Control;
            MyWeekHeader.Location = new Point(446, 40);
            MyWeekHeader.Name = "MyWeekHeader";
            MyWeekHeader.Size = new Size(274, 45);
            MyWeekHeader.TabIndex = 13;
            MyWeekHeader.Text = "Cooking Method";
            // 
            // myWeekButton
            // 
            myWeekButton.BackColor = Color.FromArgb(56, 163, 165);
            myWeekButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myWeekButton.ForeColor = SystemColors.Control;
            myWeekButton.Location = new Point(86, 2);
            myWeekButton.Margin = new Padding(2);
            myWeekButton.Name = "myWeekButton";
            myWeekButton.Size = new Size(80, 37);
            myWeekButton.TabIndex = 7;
            myWeekButton.Text = "My Week";
            myWeekButton.UseVisualStyleBackColor = false;
            myWeekButton.Click += myWeekButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerPanel.BackColor = Color.LightCyan;
            headerPanel.BackgroundImage = Properties.Resources.Header_image;
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(MyWeekHeader);
            headerPanel.Controls.Add(flowLayoutPanel2);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1200, 120);
            headerPanel.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(browserButton);
            flowLayoutPanel2.Controls.Add(myWeekButton);
            flowLayoutPanel2.Location = new Point(23, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(176, 41);
            flowLayoutPanel2.TabIndex = 41;
            // 
            // CookingMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(headerPanel);
            Controls.Add(panel2);
            Name = "CookingMethod";
            Size = new Size(1200, 900);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private Panel panel2;
        private Button removeFromWeekButton;
        private ComboBox myWeekComboBox;
        private Button addToWeekButton;
        private Panel panel7;
        private TextBox cookingInstructionTextBox;
        private Label label3;
        private Panel panel6;
        private Label label2;
        private ListBox ingredientsListBox;
        private Panel panel5;
        private Label cuisineText;
        private Label cuisineLabel;
        private Label categoryText;
        private Label categoryLabel;
        private Label tagsText;
        private Label tagsLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Button browserButton;
        private Label MyWeekHeader;
        private Button myWeekButton;
        private Panel headerPanel;
        private TextBox RecipeName;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
