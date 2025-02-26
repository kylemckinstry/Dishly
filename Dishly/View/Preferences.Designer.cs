namespace Dishly.View
{
    partial class Preferences
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
            headerPanel = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            browserButton = new Button();
            favouritesHeader = new Label();
            label4 = new Label();
            process1 = new System.Diagnostics.Process();
            panel4 = new Panel();
            label3 = new Label();
            Wheat = new CheckBox();
            Onions = new CheckBox();
            Pickles = new CheckBox();
            Milk = new CheckBox();
            Suggar = new CheckBox();
            panel3 = new Panel();
            label2 = new Label();
            Olive_Oil = new CheckBox();
            Butter = new CheckBox();
            Honey = new CheckBox();
            Vinegar = new CheckBox();
            Garlic = new CheckBox();
            panel2 = new Panel();
            label1 = new Label();
            Chicken = new CheckBox();
            Lamb = new CheckBox();
            Fish = new CheckBox();
            Beef = new CheckBox();
            Pork = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitter1 = new Splitter();
            panel1 = new Panel();
            headerPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerPanel.BackColor = Color.LightCyan;
            headerPanel.BackgroundImage = Properties.Resources.Header_image;
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(flowLayoutPanel2);
            headerPanel.Controls.Add(favouritesHeader);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1202, 120);
            headerPanel.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(browserButton);
            flowLayoutPanel2.Location = new Point(23, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(176, 41);
            flowLayoutPanel2.TabIndex = 36;
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
            browserButton.TabIndex = 7;
            browserButton.Text = "Browser";
            browserButton.UseVisualStyleBackColor = false;
            browserButton.Click += browserButton_Click;
            // 
            // favouritesHeader
            // 
            favouritesHeader.Anchor = AnchorStyles.Top;
            favouritesHeader.AutoSize = true;
            favouritesHeader.BackColor = Color.Transparent;
            favouritesHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favouritesHeader.ForeColor = SystemColors.Control;
            favouritesHeader.Location = new Point(429, 40);
            favouritesHeader.Name = "favouritesHeader";
            favouritesHeader.Size = new Size(359, 45);
            favouritesHeader.TabIndex = 13;
            favouritesHeader.Text = "Ingredient Preferences";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(56, 163, 165);
            label4.Location = new Point(326, 26);
            label4.Name = "label4";
            label4.Size = new Size(547, 32);
            label4.TabIndex = 33;
            label4.Text = "Please select the ingredients you wish to avoid";
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Wheat);
            panel4.Controls.Add(Onions);
            panel4.Controls.Add(Pickles);
            panel4.Controls.Add(Milk);
            panel4.Controls.Add(Suggar);
            panel4.Location = new Point(500, 10);
            panel4.Margin = new Padding(5, 10, 10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 336);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Size = new Size(214, 25);
            label3.TabIndex = 16;
            label3.Text = "Additional Preferences";
            // 
            // Wheat
            // 
            Wheat.AutoSize = true;
            Wheat.Font = new Font("Segoe UI", 12F);
            Wheat.Location = new Point(23, 65);
            Wheat.Margin = new Padding(2);
            Wheat.Name = "Wheat";
            Wheat.Size = new Size(74, 25);
            Wheat.TabIndex = 32;
            Wheat.Text = "Wheat";
            Wheat.UseVisualStyleBackColor = true;
            Wheat.CheckedChanged += Wheat_CheckedChanged;
            // 
            // Onions
            // 
            Onions.AutoSize = true;
            Onions.Font = new Font("Segoe UI", 12F);
            Onions.Location = new Point(23, 290);
            Onions.Margin = new Padding(2);
            Onions.Name = "Onions";
            Onions.Size = new Size(79, 25);
            Onions.TabIndex = 28;
            Onions.Text = "Onions";
            Onions.UseVisualStyleBackColor = true;
            Onions.CheckedChanged += Onions_CheckedChanged;
            // 
            // Pickles
            // 
            Pickles.AutoSize = true;
            Pickles.Font = new Font("Segoe UI", 12F);
            Pickles.Location = new Point(23, 232);
            Pickles.Margin = new Padding(2);
            Pickles.Name = "Pickles";
            Pickles.Size = new Size(76, 25);
            Pickles.TabIndex = 29;
            Pickles.Text = "Pickles";
            Pickles.UseVisualStyleBackColor = true;
            Pickles.CheckedChanged += Pickles_CheckedChanged;
            // 
            // Milk
            // 
            Milk.AutoSize = true;
            Milk.Font = new Font("Segoe UI", 12F);
            Milk.Location = new Point(23, 119);
            Milk.Margin = new Padding(2);
            Milk.Name = "Milk";
            Milk.Size = new Size(59, 25);
            Milk.TabIndex = 31;
            Milk.Text = "Milk";
            Milk.UseVisualStyleBackColor = true;
            Milk.CheckedChanged += Milk_CheckedChanged;
            // 
            // Suggar
            // 
            Suggar.AutoSize = true;
            Suggar.Font = new Font("Segoe UI", 12F);
            Suggar.Location = new Point(23, 176);
            Suggar.Margin = new Padding(2);
            Suggar.Name = "Suggar";
            Suggar.Size = new Size(79, 25);
            Suggar.TabIndex = 30;
            Suggar.Text = "Suggar";
            Suggar.UseVisualStyleBackColor = true;
            Suggar.CheckedChanged += Suggar_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(Olive_Oil);
            panel3.Controls.Add(Butter);
            panel3.Controls.Add(Honey);
            panel3.Controls.Add(Vinegar);
            panel3.Controls.Add(Garlic);
            panel3.Location = new Point(255, 10);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 336);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(70, 11);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 15;
            label2.Text = "Additives";
            label2.Click += label2_Click;
            // 
            // Olive_Oil
            // 
            Olive_Oil.AutoSize = true;
            Olive_Oil.Font = new Font("Segoe UI", 12F);
            Olive_Oil.Location = new Point(38, 65);
            Olive_Oil.Margin = new Padding(2);
            Olive_Oil.Name = "Olive_Oil";
            Olive_Oil.Size = new Size(89, 25);
            Olive_Oil.TabIndex = 27;
            Olive_Oil.Text = "Olive Oil";
            Olive_Oil.UseVisualStyleBackColor = true;
            Olive_Oil.CheckedChanged += Olive_Oil_CheckedChanged;
            // 
            // Butter
            // 
            Butter.AutoSize = true;
            Butter.Font = new Font("Segoe UI", 12F);
            Butter.Location = new Point(38, 290);
            Butter.Margin = new Padding(2);
            Butter.Name = "Butter";
            Butter.Size = new Size(71, 25);
            Butter.TabIndex = 23;
            Butter.Text = "Butter";
            Butter.UseVisualStyleBackColor = true;
            Butter.CheckedChanged += Butter_CheckedChanged;
            // 
            // Honey
            // 
            Honey.AutoSize = true;
            Honey.Font = new Font("Segoe UI", 12F);
            Honey.Location = new Point(38, 232);
            Honey.Margin = new Padding(2);
            Honey.Name = "Honey";
            Honey.Size = new Size(74, 25);
            Honey.TabIndex = 24;
            Honey.Text = "Honey";
            Honey.UseVisualStyleBackColor = true;
            Honey.CheckedChanged += Honey_CheckedChanged;
            // 
            // Vinegar
            // 
            Vinegar.AutoSize = true;
            Vinegar.Font = new Font("Segoe UI", 12F);
            Vinegar.Location = new Point(38, 119);
            Vinegar.Margin = new Padding(2);
            Vinegar.Name = "Vinegar";
            Vinegar.Size = new Size(83, 25);
            Vinegar.TabIndex = 26;
            Vinegar.Text = "Vinegar";
            Vinegar.UseVisualStyleBackColor = true;
            Vinegar.CheckedChanged += Vinegar_CheckedChanged;
            // 
            // Garlic
            // 
            Garlic.AutoSize = true;
            Garlic.Font = new Font("Segoe UI", 12F);
            Garlic.Location = new Point(38, 176);
            Garlic.Margin = new Padding(2);
            Garlic.Name = "Garlic";
            Garlic.Size = new Size(69, 25);
            Garlic.TabIndex = 25;
            Garlic.Text = "Garlic";
            Garlic.UseVisualStyleBackColor = true;
            Garlic.CheckedChanged += Garlic_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Chicken);
            panel2.Controls.Add(Lamb);
            panel2.Controls.Add(Fish);
            panel2.Controls.Add(Beef);
            panel2.Controls.Add(Pork);
            panel2.Location = new Point(10, 10);
            panel2.Margin = new Padding(10, 10, 5, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 336);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(33, 11);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 14;
            label1.Text = "Meat Preferences";
            label1.Click += label1_Click;
            // 
            // Chicken
            // 
            Chicken.AutoSize = true;
            Chicken.Font = new Font("Segoe UI", 12F);
            Chicken.Location = new Point(33, 65);
            Chicken.Margin = new Padding(2);
            Chicken.Name = "Chicken";
            Chicken.Size = new Size(84, 25);
            Chicken.TabIndex = 18;
            Chicken.Text = "Chicken";
            Chicken.UseVisualStyleBackColor = true;
            Chicken.CheckedChanged += Chicken_CheckedChanged;
            // 
            // Lamb
            // 
            Lamb.AutoSize = true;
            Lamb.Font = new Font("Segoe UI", 12F);
            Lamb.Location = new Point(33, 119);
            Lamb.Margin = new Padding(2);
            Lamb.Name = "Lamb";
            Lamb.Size = new Size(68, 25);
            Lamb.TabIndex = 19;
            Lamb.Text = "Lamb";
            Lamb.UseVisualStyleBackColor = true;
            Lamb.CheckedChanged += Lamb_CheckedChanged;
            // 
            // Fish
            // 
            Fish.AutoSize = true;
            Fish.Font = new Font("Segoe UI", 12F);
            Fish.Location = new Point(33, 290);
            Fish.Margin = new Padding(2);
            Fish.Name = "Fish";
            Fish.Size = new Size(57, 25);
            Fish.TabIndex = 22;
            Fish.Text = "Fish";
            Fish.UseVisualStyleBackColor = true;
            Fish.CheckedChanged += Fish_CheckedChanged;
            // 
            // Beef
            // 
            Beef.AutoSize = true;
            Beef.Font = new Font("Segoe UI", 12F);
            Beef.Location = new Point(33, 176);
            Beef.Margin = new Padding(2);
            Beef.Name = "Beef";
            Beef.Size = new Size(59, 25);
            Beef.TabIndex = 20;
            Beef.Text = "Beef";
            Beef.UseVisualStyleBackColor = true;
            Beef.CheckedChanged += Beef_CheckedChanged;
            // 
            // Pork
            // 
            Pork.AutoSize = true;
            Pork.Font = new Font("Segoe UI", 12F);
            Pork.Location = new Point(33, 232);
            Pork.Margin = new Padding(2);
            Pork.Name = "Pork";
            Pork.Size = new Size(60, 25);
            Pork.TabIndex = 21;
            Pork.Text = "Pork";
            Pork.UseVisualStyleBackColor = true;
            Pork.CheckedChanged += Pork_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(227, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(745, 361);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 1000);
            splitter1.TabIndex = 34;
            splitter1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(splitter1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 122);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 1000);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // Preferences
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(panel1);
            Controls.Add(headerPanel);
            Margin = new Padding(2);
            Name = "Preferences";
            Size = new Size(1202, 1124);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label favouritesHeader;
        private Button browserButton;
        private System.Diagnostics.Process process1;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private CheckBox Chicken;
        private CheckBox Lamb;
        private CheckBox Fish;
        private CheckBox Beef;
        private CheckBox Pork;
        private Panel panel3;
        private Label label2;
        private CheckBox Olive_Oil;
        private CheckBox Butter;
        private CheckBox Honey;
        private CheckBox Vinegar;
        private CheckBox Garlic;
        private Panel panel4;
        private Label label3;
        private CheckBox Wheat;
        private CheckBox Onions;
        private CheckBox Pickles;
        private CheckBox Milk;
        private CheckBox Suggar;
        private Panel panel1;
        private Splitter splitter1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
