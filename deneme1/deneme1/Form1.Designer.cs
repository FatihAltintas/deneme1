namespace deneme1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Cornsilk;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Osman Gazi", "Orhan Gazi", "I. Murad (Hüdavendigar)", "I. Bayezid (Yıldırım)", "I. Mehmed (Çelebi)", "II. Murad", "II. Mehmed (Fatih)", "II. Bayezid", "I. Selim (Yavuz)", "I. Süleyman (Kanuni)" });
            listBox1.Location = new Point(12, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Cornsilk;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(230, 46);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(363, 304);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 375);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 2;
            label1.Text = "Araştırılacak Padişahı Giriniz:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Cornsilk;
            textBox1.Location = new Point(12, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Padişah Listesi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 9);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 5;
            label3.Text = "Girdiği Savaşlar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 375);
            label4.Name = "label4";
            label4.Size = new Size(231, 20);
            label4.TabIndex = 6;
            label4.Text = "Görmek İstediğiniz Savaşı Seçiniz:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Cornsilk;
            textBox2.Location = new Point(230, 411);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 27);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 495);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 8;
            label5.Text = "Savaşın Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 548);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 9;
            label6.Text = "Sonuç:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Cornsilk;
            textBox3.Location = new Point(230, 518);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Cornsilk;
            textBox4.Location = new Point(230, 571);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(363, 27);
            textBox4.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(60, 533);
            button1.Name = "button1";
            button1.Size = new Size(94, 50);
            button1.TabIndex = 12;
            button1.Text = "GÖSTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(665, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(683, 710);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1347, 707);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private PictureBox pictureBox1;
    }
}