namespace Dishly.View
{
    partial class IngredientsList
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
            IngredientsListHeader = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            favouritesButton = new Button();
            browserButton = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            headerPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerPanel.BackColor = Color.LightCyan;
            headerPanel.BackgroundImage = Properties.Resources.Header_image;
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(IngredientsListHeader);
            headerPanel.Controls.Add(flowLayoutPanel2);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1200, 120);
            headerPanel.TabIndex = 9;
            // 
            // IngredientsListHeader
            // 
            IngredientsListHeader.Anchor = AnchorStyles.Top;
            IngredientsListHeader.AutoSize = true;
            IngredientsListHeader.BackColor = Color.Transparent;
            IngredientsListHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IngredientsListHeader.ForeColor = SystemColors.Control;
            IngredientsListHeader.Location = new Point(475, 40);
            IngredientsListHeader.Name = "IngredientsListHeader";
            IngredientsListHeader.Size = new Size(250, 45);
            IngredientsListHeader.TabIndex = 14;
            IngredientsListHeader.Text = "Ingredients List";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(favouritesButton);
            flowLayoutPanel2.Controls.Add(browserButton);
            flowLayoutPanel2.Location = new Point(23, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(176, 41);
            flowLayoutPanel2.TabIndex = 50;
            // 
            // favouritesButton
            // 
            favouritesButton.BackColor = Color.FromArgb(255, 129, 51);
            favouritesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favouritesButton.ForeColor = SystemColors.Control;
            favouritesButton.Location = new Point(2, 2);
            favouritesButton.Margin = new Padding(2);
            favouritesButton.Name = "favouritesButton";
            favouritesButton.Size = new Size(80, 37);
            favouritesButton.TabIndex = 9;
            favouritesButton.Text = "Browser";
            favouritesButton.UseVisualStyleBackColor = false;
            favouritesButton.Click += favouritesButton_Click;
            // 
            // browserButton
            // 
            browserButton.BackColor = Color.FromArgb(87, 204, 153);
            browserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browserButton.ForeColor = SystemColors.Control;
            browserButton.Location = new Point(86, 2);
            browserButton.Margin = new Padding(2);
            browserButton.Name = "browserButton";
            browserButton.Size = new Size(80, 37);
            browserButton.TabIndex = 7;
            browserButton.Text = "My Week";
            browserButton.UseVisualStyleBackColor = false;
            browserButton.Click += browserButton_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 10F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Items.AddRange(new object[] { "<ingredient #1>", "<ingredient #2>", "<ingredient #3>" });
            listBox2.Location = new Point(15, 109);
            listBox2.Margin = new Padding(15, 10, 15, 10);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(426, 378);
            listBox2.TabIndex = 45;
/*            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;*/
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(87, 204, 153);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 0);
            label1.Size = new Size(169, 37);
            label1.TabIndex = 14;
            label1.Text = "Shopping List";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(listBox2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(373, 176);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(453, 547);
            flowLayoutPanel1.TabIndex = 46;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10, 10, 10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 46);
            panel1.TabIndex = 48;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 66);
            panel2.Margin = new Padding(15, 10, 10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 33);
            panel2.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(56, 163, 165);
            label2.Location = new Point(1, 3);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 15;
            label2.Text = "Item + Quantity";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 129, 51);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(15, 497);
            button1.Margin = new Padding(15, 0, 10, 10);
            button1.Name = "button1";
            button1.Size = new Size(80, 37);
            button1.TabIndex = 47;
            button1.Text = "Print List";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // IngredientsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(headerPanel);
            Margin = new Padding(2);
            Name = "IngredientsList";
            Size = new Size(1200, 1000);
            Load += IngredientsList_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Button favouritesButton;
        private Button browserButton;
        private Label label1;
        private ListBox listBox2;
        private Label IngredientsListHeader;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label2;
    }
}
