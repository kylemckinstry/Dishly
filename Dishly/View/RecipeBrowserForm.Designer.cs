namespace Dishly
{
    partial class RecipeBrowserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button searchButton;
        private Panel mainPanel2;
        private PictureBox pictureBox1;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeBrowserForm));
            searchButton = new Button();
            mainPanel2 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            headerPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            shoppingListButton = new Button();
            PreferencesButton = new Button();
            logo = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            favouritesButton = new Button();
            myWeekButton = new Button();
            mainSearchBox = new TextBox();
            button2 = new Button();
            mainPanel3 = new Panel();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            mainPanel4 = new Panel();
            textBox5 = new TextBox();
            pictureBox3 = new PictureBox();
            mainPanel5 = new Panel();
            textBox7 = new TextBox();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            mainPanel9 = new Panel();
            textBox15 = new TextBox();
            pictureBox8 = new PictureBox();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            mainPanel8 = new Panel();
            textBox13 = new TextBox();
            pictureBox7 = new PictureBox();
            button5 = new Button();
            mainPanel6 = new Panel();
            textBox9 = new TextBox();
            pictureBox6 = new PictureBox();
            textBox11 = new TextBox();
            mainPanel7 = new Panel();
            myWeek1 = new View.MyWeek();
            shuffleButton = new Button();
            cookingMethod1 = new CookingMethod();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            showNextButton = new Button();
            showPreviousButton = new Button();
            mainPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            headerPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            mainPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mainPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            mainPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            mainPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            mainPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            mainPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            mainPanel7.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(87, 204, 153);
            searchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = SystemColors.Control;
            searchButton.Location = new Point(389, 3);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(116, 29);
            searchButton.TabIndex = 0;
            searchButton.Text = "Get Recipes";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // mainPanel2
            // 
            mainPanel2.BackColor = Color.WhiteSmoke;
            mainPanel2.Controls.Add(textBox1);
            mainPanel2.Controls.Add(pictureBox1);
            mainPanel2.Location = new Point(8, 8);
            mainPanel2.Margin = new Padding(8);
            mainPanel2.Name = "mainPanel2";
            mainPanel2.Size = new Size(225, 215);
            mainPanel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 184);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox_Click;
            // 
            // headerPanel
            // 
            headerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerPanel.BackColor = Color.LightCyan;
            headerPanel.BackgroundImage = (Image)resources.GetObject("headerPanel.BackgroundImage");
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(flowLayoutPanel1);
            headerPanel.Controls.Add(logo);
            headerPanel.Controls.Add(flowLayoutPanel2);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1185, 120);
            headerPanel.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(shoppingListButton);
            flowLayoutPanel1.Controls.Add(PreferencesButton);
            flowLayoutPanel1.Location = new Point(919, 40);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(231, 41);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // shoppingListButton
            // 
            shoppingListButton.BackColor = Color.FromArgb(87, 204, 153);
            shoppingListButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shoppingListButton.ForeColor = Color.White;
            shoppingListButton.Location = new Point(2, 2);
            shoppingListButton.Margin = new Padding(2);
            shoppingListButton.Name = "shoppingListButton";
            shoppingListButton.Size = new Size(104, 37);
            shoppingListButton.TabIndex = 34;
            shoppingListButton.Text = "Shopping List";
            shoppingListButton.UseVisualStyleBackColor = false;
            shoppingListButton.Click += shoppingListButton_Click;
            // 
            // PreferencesButton
            // 
            PreferencesButton.BackColor = Color.FromArgb(255, 129, 51);
            PreferencesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreferencesButton.ForeColor = Color.White;
            PreferencesButton.Location = new Point(110, 2);
            PreferencesButton.Margin = new Padding(2);
            PreferencesButton.Name = "PreferencesButton";
            PreferencesButton.Size = new Size(111, 37);
            PreferencesButton.TabIndex = 33;
            PreferencesButton.Text = "Preferences";
            PreferencesButton.UseVisualStyleBackColor = false;
            PreferencesButton.Click += preferencesButton_Click;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Top;
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.Dishly_logo_white;
            logo.Location = new Point(494, 33);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Padding = new Padding(15, 0, 15, 0);
            logo.Size = new Size(192, 54);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 9;
            logo.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(favouritesButton);
            flowLayoutPanel2.Controls.Add(myWeekButton);
            flowLayoutPanel2.Location = new Point(23, 40);
            flowLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(176, 41);
            flowLayoutPanel2.TabIndex = 35;
            // 
            // favouritesButton
            // 
            favouritesButton.BackColor = Color.FromArgb(56, 163, 165);
            favouritesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favouritesButton.ForeColor = SystemColors.Control;
            favouritesButton.Location = new Point(2, 2);
            favouritesButton.Margin = new Padding(2);
            favouritesButton.Name = "favouritesButton";
            favouritesButton.Size = new Size(80, 37);
            favouritesButton.TabIndex = 7;
            favouritesButton.Text = "Favorites";
            favouritesButton.UseVisualStyleBackColor = false;
            favouritesButton.Click += favouritesButton_Click;
            // 
            // myWeekButton
            // 
            myWeekButton.BackColor = Color.FromArgb(87, 204, 153);
            myWeekButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myWeekButton.ForeColor = Color.White;
            myWeekButton.Location = new Point(86, 2);
            myWeekButton.Margin = new Padding(2);
            myWeekButton.Name = "myWeekButton";
            myWeekButton.Size = new Size(80, 37);
            myWeekButton.TabIndex = 7;
            myWeekButton.Text = "My Week";
            myWeekButton.UseVisualStyleBackColor = false;
            myWeekButton.Click += myWeekButton_Click;
            // 
            // mainSearchBox
            // 
            mainSearchBox.BackColor = Color.WhiteSmoke;
            mainSearchBox.Font = new Font("Segoe UI", 12F);
            mainSearchBox.Location = new Point(2, 2);
            mainSearchBox.Margin = new Padding(2);
            mainSearchBox.Name = "mainSearchBox";
            mainSearchBox.PlaceholderText = " Enter an ingredient or dish name";
            mainSearchBox.Size = new Size(381, 29);
            mainSearchBox.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(1078, 187);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(6, 5);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // mainPanel3
            // 
            mainPanel3.BackColor = Color.WhiteSmoke;
            mainPanel3.Controls.Add(textBox3);
            mainPanel3.Controls.Add(pictureBox2);
            mainPanel3.Location = new Point(249, 8);
            mainPanel3.Margin = new Padding(8);
            mainPanel3.Name = "mainPanel3";
            mainPanel3.Size = new Size(225, 215);
            mainPanel3.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 184);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 23);
            textBox3.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox_Click;
            // 
            // mainPanel4
            // 
            mainPanel4.BackColor = Color.WhiteSmoke;
            mainPanel4.Controls.Add(textBox5);
            mainPanel4.Controls.Add(pictureBox3);
            mainPanel4.Location = new Point(490, 8);
            mainPanel4.Margin = new Padding(8);
            mainPanel4.Name = "mainPanel4";
            mainPanel4.Size = new Size(225, 215);
            mainPanel4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(8, 184);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(210, 23);
            textBox5.TabIndex = 34;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(8, 8);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(210, 170);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox_Click;
            // 
            // mainPanel5
            // 
            mainPanel5.BackColor = Color.WhiteSmoke;
            mainPanel5.Controls.Add(textBox7);
            mainPanel5.Controls.Add(pictureBox4);
            mainPanel5.Location = new Point(731, 8);
            mainPanel5.Margin = new Padding(8);
            mainPanel5.Name = "mainPanel5";
            mainPanel5.Size = new Size(225, 215);
            mainPanel5.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(8, 184);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(210, 23);
            textBox7.TabIndex = 35;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(8, 8);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(210, 170);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1429, 184);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(6, 5);
            button3.TabIndex = 15;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // mainPanel9
            // 
            mainPanel9.BackColor = Color.WhiteSmoke;
            mainPanel9.Controls.Add(textBox15);
            mainPanel9.Controls.Add(pictureBox8);
            mainPanel9.Location = new Point(731, 239);
            mainPanel9.Margin = new Padding(8);
            mainPanel9.Name = "mainPanel9";
            mainPanel9.Size = new Size(225, 215);
            mainPanel9.TabIndex = 30;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(8, 184);
            textBox15.Margin = new Padding(4, 3, 4, 3);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(210, 23);
            textBox15.TabIndex = 36;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(8, 8);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(210, 170);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(8, 8);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(210, 170);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1429, 510);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(6, 5);
            button4.TabIndex = 29;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // mainPanel8
            // 
            mainPanel8.BackColor = Color.WhiteSmoke;
            mainPanel8.Controls.Add(textBox13);
            mainPanel8.Controls.Add(pictureBox7);
            mainPanel8.Location = new Point(490, 239);
            mainPanel8.Margin = new Padding(8);
            mainPanel8.Name = "mainPanel8";
            mainPanel8.Size = new Size(225, 215);
            mainPanel8.TabIndex = 26;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(8, 184);
            textBox13.Margin = new Padding(4, 3, 4, 3);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(210, 23);
            textBox13.TabIndex = 35;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(8, 8);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(210, 170);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1153, 526);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(6, 5);
            button5.TabIndex = 22;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // mainPanel6
            // 
            mainPanel6.BackColor = Color.WhiteSmoke;
            mainPanel6.Controls.Add(textBox9);
            mainPanel6.Controls.Add(pictureBox5);
            mainPanel6.Location = new Point(8, 239);
            mainPanel6.Margin = new Padding(8);
            mainPanel6.Name = "mainPanel6";
            mainPanel6.Size = new Size(225, 215);
            mainPanel6.TabIndex = 19;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(8, 184);
            textBox9.Margin = new Padding(4, 3, 4, 3);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(210, 23);
            textBox9.TabIndex = 33;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(8, 8);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(210, 170);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(8, 184);
            textBox11.Margin = new Padding(4, 3, 4, 3);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(210, 23);
            textBox11.TabIndex = 34;
            // 
            // mainPanel7
            // 
            mainPanel7.BackColor = Color.WhiteSmoke;
            mainPanel7.Controls.Add(textBox11);
            mainPanel7.Controls.Add(pictureBox6);
            mainPanel7.Location = new Point(249, 239);
            mainPanel7.Margin = new Padding(8);
            mainPanel7.Name = "mainPanel7";
            mainPanel7.Size = new Size(225, 215);
            mainPanel7.TabIndex = 23;
            // 
            // myWeek1
            // 
            myWeek1.AutoScroll = true;
            myWeek1.AutoSize = true;
            myWeek1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            myWeek1.BackColor = Color.White;
            myWeek1.Location = new Point(24, 903);
            myWeek1.Margin = new Padding(4, 5, 4, 5);
            myWeek1.MaximumSize = new Size(1200, 1000);
            myWeek1.MinimumSize = new Size(700, 700);
            myWeek1.Name = "myWeek1";
            myWeek1.Size = new Size(700, 1000);
            myWeek1.TabIndex = 31;
            myWeek1.Visible = false;
            // 
            // shuffleButton
            // 
            shuffleButton.BackColor = Color.FromArgb(255, 129, 51);
            shuffleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shuffleButton.ForeColor = SystemColors.Control;
            shuffleButton.Location = new Point(511, 2);
            shuffleButton.Margin = new Padding(2);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(76, 29);
            shuffleButton.TabIndex = 32;
            shuffleButton.Text = "Shuffle";
            shuffleButton.UseVisualStyleBackColor = false;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // cookingMethod1
            // 
            cookingMethod1.AutoSize = true;
            cookingMethod1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cookingMethod1.Location = new Point(97, 837);
            cookingMethod1.Margin = new Padding(6);
            cookingMethod1.Name = "cookingMethod1";
            cookingMethod1.Size = new Size(0, 832);
            cookingMethod1.TabIndex = 33;
            cookingMethod1.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel3.Controls.Add(mainPanel2);
            flowLayoutPanel3.Controls.Add(mainPanel3);
            flowLayoutPanel3.Controls.Add(mainPanel4);
            flowLayoutPanel3.Controls.Add(mainPanel5);
            flowLayoutPanel3.Controls.Add(mainPanel6);
            flowLayoutPanel3.Controls.Add(mainPanel7);
            flowLayoutPanel3.Controls.Add(mainPanel8);
            flowLayoutPanel3.Controls.Add(mainPanel9);
            flowLayoutPanel3.Location = new Point(116, 196);
            flowLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(980, 467);
            flowLayoutPanel3.TabIndex = 34;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top;
            flowLayoutPanel4.Controls.Add(mainSearchBox);
            flowLayoutPanel4.Controls.Add(searchButton);
            flowLayoutPanel4.Controls.Add(shuffleButton);
            flowLayoutPanel4.Location = new Point(309, 142);
            flowLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(590, 40);
            flowLayoutPanel4.TabIndex = 35;
            // 
            // showNextButton
            // 
            showNextButton.BackColor = Color.FromArgb(56, 163, 165);
            showNextButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showNextButton.ForeColor = SystemColors.Control;
            showNextButton.Location = new Point(654, 676);
            showNextButton.Margin = new Padding(4, 3, 4, 3);
            showNextButton.Name = "showNextButton";
            showNextButton.Size = new Size(116, 29);
            showNextButton.TabIndex = 36;
            showNextButton.Text = "Next";
            showNextButton.UseVisualStyleBackColor = false;
            showNextButton.Click += showNextButton_Click;
            // 
            // showPreviousButton
            // 
            showPreviousButton.BackColor = Color.Salmon;
            showPreviousButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPreviousButton.ForeColor = SystemColors.Control;
            showPreviousButton.Location = new Point(419, 676);
            showPreviousButton.Margin = new Padding(4, 3, 4, 3);
            showPreviousButton.Name = "showPreviousButton";
            showPreviousButton.Size = new Size(116, 29);
            showPreviousButton.TabIndex = 37;
            showPreviousButton.Text = "Previous";
            showPreviousButton.UseVisualStyleBackColor = false;
            showPreviousButton.Click += showPreviousButton_Click;
            // 
            // RecipeBrowserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 861);
            Controls.Add(showPreviousButton);
            Controls.Add(showNextButton);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(cookingMethod1);
            Controls.Add(myWeek1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(headerPanel);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(1200, 950);
            MinimumSize = new Size(846, 634);
            Name = "RecipeBrowserForm";
            Text = "Recipe Finder";
            mainPanel2.ResumeLayout(false);
            mainPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            headerPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            mainPanel3.ResumeLayout(false);
            mainPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mainPanel4.ResumeLayout(false);
            mainPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            mainPanel5.ResumeLayout(false);
            mainPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            mainPanel9.ResumeLayout(false);
            mainPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            mainPanel8.ResumeLayout(false);
            mainPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            mainPanel6.ResumeLayout(false);
            mainPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            mainPanel7.ResumeLayout(false);
            mainPanel7.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private Button myWeekButton;
        private Button favouritesButton;
        private TextBox mainSearchBox;
        private Button button2;
        private Panel mainPanel3;
        private PictureBox pictureBox2;
        private Panel mainPanel4;
        private PictureBox pictureBox3;
        private Panel mainPanel5;
        private PictureBox pictureBox4;
        private Button button3;
        private Panel mainPanel9;
        private PictureBox pictureBox5;
        private Button button4;
        private Panel mainPanel8;
        private PictureBox pictureBox7;
        private Button button5;
        private Panel mainPanel6;
        private PictureBox pictureBox8;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox15;
        private TextBox textBox13;
        private TextBox textBox9;
        private TextBox textBox1;
        private PictureBox pictureBox6;
        private TextBox textBox11;
        private Panel mainPanel7;
        public View.RecipeDetailForm recipeDetail1;
        private View.Favourites favourites1;
        private View.Preferences preferences1;
        private View.IngredientsList ingredientsList1;
        private PictureBox logo;
        private View.MyWeek myWeek1;
        private Button shuffleButton;
        private Button shoppingListButton;
        public CookingMethod cookingMethod1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button PreferencesButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button showNextButton;
        private Button showPreviousButton;
    }
}
