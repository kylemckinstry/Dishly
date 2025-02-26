namespace Dishly.View
{
    partial class Favourites
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
            favouritesHeader = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            browserButton = new Button();
            myWeekButton = new Button();
            mainPanel8 = new Panel();
            textBox13 = new TextBox();
            pictureBox7 = new PictureBox();
            mainPanel7 = new Panel();
            textBox11 = new TextBox();
            pictureBox6 = new PictureBox();
            mainPanel6 = new Panel();
            textBox9 = new TextBox();
            pictureBox5 = new PictureBox();
            mainPanel5 = new Panel();
            textBox1 = new TextBox();
            pictureBox4 = new PictureBox();
            mainPanel4 = new Panel();
            textBox5 = new TextBox();
            pictureBox3 = new PictureBox();
            mainPanel3 = new Panel();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            mainPanel2 = new Panel();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            mainPanel9 = new Panel();
            textBox15 = new TextBox();
            pictureBox8 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            headerPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            mainPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            mainPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            mainPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            mainPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            mainPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            mainPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mainPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerPanel.BackColor = Color.LightCyan;
            headerPanel.BackgroundImage = Properties.Resources.Header_image;
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(favouritesHeader);
            headerPanel.Controls.Add(flowLayoutPanel2);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1200, 120);
            headerPanel.TabIndex = 7;
            // 
            // favouritesHeader
            // 
            favouritesHeader.Anchor = AnchorStyles.Top;
            favouritesHeader.AutoSize = true;
            favouritesHeader.BackColor = Color.Transparent;
            favouritesHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favouritesHeader.ForeColor = SystemColors.Control;
            favouritesHeader.ImageAlign = ContentAlignment.MiddleRight;
            favouritesHeader.Location = new Point(483, 40);
            favouritesHeader.Name = "favouritesHeader";
            favouritesHeader.Size = new Size(234, 45);
            favouritesHeader.TabIndex = 13;
            favouritesHeader.Text = "Favourites List";
            favouritesHeader.TextAlign = ContentAlignment.MiddleRight;
            favouritesHeader.Click += label7_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(browserButton);
            flowLayoutPanel2.Controls.Add(myWeekButton);
            flowLayoutPanel2.Location = new Point(23, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(176, 41);
            flowLayoutPanel2.TabIndex = 40;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
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
            // myWeekButton
            // 
            myWeekButton.BackColor = Color.FromArgb(87, 204, 153);
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
            // mainPanel8
            // 
            mainPanel8.BackColor = Color.WhiteSmoke;
            mainPanel8.Controls.Add(textBox13);
            mainPanel8.Controls.Add(pictureBox7);
            mainPanel8.Location = new Point(490, 239);
            mainPanel8.Margin = new Padding(8);
            mainPanel8.Name = "mainPanel8";
            mainPanel8.Size = new Size(225, 215);
            mainPanel8.TabIndex = 37;
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
            pictureBox7.Click += PictureBox_Click;
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
            mainPanel7.TabIndex = 36;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(8, 184);
            textBox11.Margin = new Padding(4, 3, 4, 3);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(210, 23);
            textBox11.TabIndex = 34;
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
            pictureBox6.Click += PictureBox_Click;
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
            mainPanel6.TabIndex = 35;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(8, 184);
            textBox9.Margin = new Padding(4, 3, 4, 3);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(210, 23);
            textBox9.TabIndex = 33;
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
            pictureBox5.Click += PictureBox_Click;
            // 
            // mainPanel5
            // 
            mainPanel5.BackColor = Color.WhiteSmoke;
            mainPanel5.Controls.Add(textBox1);
            mainPanel5.Controls.Add(pictureBox4);
            mainPanel5.Location = new Point(731, 8);
            mainPanel5.Margin = new Padding(8);
            mainPanel5.Name = "mainPanel5";
            mainPanel5.Size = new Size(225, 215);
            mainPanel5.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 184);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 35;
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
            pictureBox4.Click += PictureBox_Click;
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
            mainPanel4.TabIndex = 33;
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
            pictureBox3.Click += PictureBox_Click;
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
            mainPanel3.TabIndex = 32;
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
            pictureBox2.Click += PictureBox_Click;
            // 
            // mainPanel2
            // 
            mainPanel2.BackColor = Color.WhiteSmoke;
            mainPanel2.Controls.Add(textBox2);
            mainPanel2.Controls.Add(pictureBox1);
            mainPanel2.Location = new Point(8, 8);
            mainPanel2.Margin = new Padding(8);
            mainPanel2.Name = "mainPanel2";
            mainPanel2.Size = new Size(225, 215);
            mainPanel2.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 184);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 34;
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
            pictureBox1.Click += PictureBox_Click;
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
            mainPanel9.TabIndex = 38;
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
            pictureBox8.Click += PictureBox_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(mainPanel2);
            flowLayoutPanel1.Controls.Add(mainPanel3);
            flowLayoutPanel1.Controls.Add(mainPanel4);
            flowLayoutPanel1.Controls.Add(mainPanel5);
            flowLayoutPanel1.Controls.Add(mainPanel6);
            flowLayoutPanel1.Controls.Add(mainPanel7);
            flowLayoutPanel1.Controls.Add(mainPanel8);
            flowLayoutPanel1.Controls.Add(mainPanel9);
            flowLayoutPanel1.Location = new Point(115, 196);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1065, 468);
            flowLayoutPanel1.TabIndex = 39;
            // 
            // Favourites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(headerPanel);
            MaximumSize = new Size(1200, 1000);
            MinimumSize = new Size(700, 700);
            Name = "Favourites";
            Size = new Size(1200, 1000);
            Load += Favourites_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            mainPanel8.ResumeLayout(false);
            mainPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            mainPanel7.ResumeLayout(false);
            mainPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            mainPanel6.ResumeLayout(false);
            mainPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            mainPanel5.ResumeLayout(false);
            mainPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            mainPanel4.ResumeLayout(false);
            mainPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            mainPanel3.ResumeLayout(false);
            mainPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mainPanel2.ResumeLayout(false);
            mainPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainPanel9.ResumeLayout(false);
            mainPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Button myWeekButton;
        private Label favouritesHeader;
        private Button browserButton;
        private Panel mainPanel8;
        private TextBox textBox13;
        private PictureBox pictureBox7;
        private Panel mainPanel7;
        private TextBox textBox11;
        private PictureBox pictureBox6;
        private Panel mainPanel6;
        private TextBox textBox9;
        private PictureBox pictureBox5;
        private Panel mainPanel5;
        private TextBox textBox1;
        private PictureBox pictureBox4;
        private Panel mainPanel4;
        private TextBox textBox5;
        private PictureBox pictureBox3;
        private Panel mainPanel3;
        private TextBox textBox3;
        private PictureBox pictureBox2;
        private Panel mainPanel2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Panel mainPanel9;
        private TextBox textBox15;
        private PictureBox pictureBox8;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
