namespace YeniOyun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
            panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
            panel1.MouseUp += new MouseEventHandler(this.panel1_MouseUp);

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            buttonMinimize = new Button();
            buttonSettings = new Button();
            buttonClose = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.BackColor = Color.FromArgb(3, 20, 30);
            listBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.FromArgb(240, 230, 210);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 50;
            listBox1.Location = new Point(564, 178);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(450, 554);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DragDrop += listBox1_DragDrop;
            listBox1.DragEnter += listBox1_DragEnter;
            listBox1.MouseDown += listBox1_MouseDown;
            // 
            // listBox2
            // 
            listBox2.AllowDrop = true;
            listBox2.BackColor = Color.FromArgb(3, 20, 30);
            listBox2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox2.ForeColor = Color.FromArgb(240, 230, 210);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 50;
            listBox2.Location = new Point(1132, 178);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(450, 554);
            listBox2.TabIndex = 3;
            listBox2.DragDrop += listBox2_DragDrop;
            listBox2.DragEnter += listBox2_DragEnter;
            listBox2.MouseDown += listBox2_MouseDown;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(3, 20, 30);
            textBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(240, 230, 210);
            textBox1.Location = new Point(52, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 568);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.carousel_outline_gold;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(240, 230, 210);
            button2.Location = new Point(52, 783);
            button2.Name = "button2";
            button2.Size = new Size(395, 99);
            button2.TabIndex = 7;
            button2.Text = "Takımları Oluştur";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(240, 230, 210);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(564, 783);
            label1.Name = "label1";
            label1.Size = new Size(562, 99);
            label1.TabIndex = 8;
            label1.Text = "Sol tarafa 10 oyuncu ismi giriniz.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.TextChanged += label1_TextChanged;
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.carousel_outline_gold;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(240, 230, 210);
            button3.Location = new Point(1132, 783);
            button3.Name = "button3";
            button3.Size = new Size(450, 99);
            button3.TabIndex = 9;
            button3.Text = "Sıfırla";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonMinimize);
            panel1.Controls.Add(buttonSettings);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1640, 66);
            panel1.TabIndex = 10;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.FromArgb(3, 20, 30);
            buttonMinimize.BackgroundImage = (Image)resources.GetObject("buttonMinimize.BackgroundImage");
            buttonMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMinimize.Location = new Point(1489, 21);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(39, 36);
            buttonMinimize.TabIndex = 19;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += button4_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(3, 20, 30);
            buttonSettings.BackgroundImage = (Image)resources.GetObject("buttonSettings.BackgroundImage");
            buttonSettings.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSettings.Location = new Point(1534, 21);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(39, 36);
            buttonSettings.TabIndex = 18;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += button1_Click_1;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(3, 20, 30);
            buttonClose.BackgroundImage = Properties.Resources.cross_button;
            buttonClose.BackgroundImageLayout = ImageLayout.Stretch;
            buttonClose.Location = new Point(1579, 21);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(39, 36);
            buttonClose.TabIndex = 2;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(240, 230, 210);
            label2.Location = new Point(51, 21);
            label2.Name = "label2";
            label2.Size = new Size(331, 36);
            label2.TabIndex = 1;
            label2.Text = "League of Legends Takım Oluşturucu";
            label2.Click += label2_Click;
            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            label2.MouseUp += label2_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(240, 230, 210);
            label3.Location = new Point(67, 117);
            label3.Name = "label3";
            label3.Size = new Size(380, 48);
            label3.TabIndex = 11;
            label3.Text = "Oyuncular";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.po_icon_helmet;
            pictureBox2.Location = new Point(107, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(240, 230, 210);
            label4.Location = new Point(600, 117);
            label4.Name = "label4";
            label4.Size = new Size(414, 48);
            label4.TabIndex = 13;
            label4.Text = "Mavi Takım";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(240, 230, 210);
            label5.Location = new Point(1188, 117);
            label5.Name = "label5";
            label5.Size = new Size(394, 48);
            label5.TabIndex = 14;
            label5.Text = "Kırmızı Takım";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(637, 117);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1197, 117);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(489, 805);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(489, 437);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 58);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1045, 437);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(55, 58);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Dune Rise", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(240, 230, 210);
            label6.Location = new Point(1422, 962);
            label6.Name = "label6";
            label6.Size = new Size(176, 22);
            label6.TabIndex = 20;
            label6.Text = "Berkay Ari";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.split_start_stats_panel_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1642, 983);
            Controls.Add(label6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "League of Legends Takım Oluşturucu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button buttonClose;
        private Button buttonMinimize;
        private Button buttonSettings;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label6;
    }
}