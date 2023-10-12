namespace uçak_bilet_satış
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            label11 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yolcu Bilgileri";
            // 
            // button2
            // 
            button2.Location = new Point(202, 289);
            button2.Name = "button2";
            button2.Size = new Size(116, 35);
            button2.TabIndex = 10;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 290);
            button1.Name = "button1";
            button1.Size = new Size(116, 35);
            button1.TabIndex = 9;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(127, 195);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(200, 36);
            maskedTextBox2.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(127, 147);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(200, 36);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 36);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 36);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 203);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 3;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 155);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 2;
            label4.Text = "TC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 101);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 1;
            label3.Text = "Soyisim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 50);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 0;
            label2.Text = "İsim:";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 141);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(510, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Informal Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(153, 34);
            label1.Name = "label1";
            label1.Size = new Size(265, 65);
            label1.TabIndex = 1;
            label1.Text = "Bilet Satış";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(438, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 386);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sefer bilgileri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 136);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 17;
            label6.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(203, 136);
            button5.Name = "button5";
            button5.Size = new Size(116, 35);
            button5.TabIndex = 11;
            button5.Text = "<>";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(216, 350);
            button3.Name = "button3";
            button3.Size = new Size(116, 35);
            button3.TabIndex = 16;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(53, 351);
            button4.Name = "button4";
            button4.Size = new Size(116, 35);
            button4.TabIndex = 15;
            button4.Text = "Kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(147, 289);
            maskedTextBox4.Mask = "     00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(103, 36);
            maskedTextBox4.TabIndex = 14;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 292);
            label11.Name = "label11";
            label11.Size = new Size(110, 28);
            label11.TabIndex = 13;
            label11.Text = "İniş Saati:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(147, 244);
            maskedTextBox3.Mask = "     00:00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(103, 36);
            maskedTextBox3.TabIndex = 13;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 36);
            dateTimePicker1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Adana 01", "Adıyaman 02", "Afyon 03", "Ağrı 04", "Amasya 05", "Ankara 06", "Antalya 07", "Artvin 08", "Aydın 09", "Balıkesir 10", "Bilecik 11", "Bingöl 12", "Bitlis 13", "Bolu 14", "Burdur 15", "Bursa 16", "Çanakkale 17", "Çanakkale 17", "Çankırı 18", "Çorum 19", "Denizli 20", "Diyarbakır 21", "Edirne 22", "Elazığ 23", "Erzincan 24", "Erzurum 25", "Eskişehir 26", "Gaziantep 27", "Giresun 28", "Gümüşhane 29", "Hakkari 30", "Hatay 31", "Isparta 32", "Mersin 33", "İstanbul 34", "İzmir 35", "Kars 36", "Kastamonu 37", "Kayseri 38", "Kırklareli 39", "Kırşehir 40", "Kocaeli 41", "Konya 42", "Kütahya 43", "Malatya 44", "Manisa 45", "Kahramanmaraş 46", "Mardin 47", "Muğla 48", "Muş 49", "Nevşehir 50", "Niğde 51", "Ordu 52", "Rize 53", "Sakarya 54", "Samsun 55", "Siirt 56", "Sinop 57", "Sivas 58", "Tekirdağ 59", "Tokat 60", "Trabzon 61", "Tunceli 62", "Şanlıurfa 63", "Uşak 64", "Van 65", "Yozgat 66", "Zonguldak 67", "Aksaray 68", "Bayburt 69", "Karaman 70", "Kırıkkale 71", "Batman 72", "Şırnak 73", "Bartın 74", "Ardahan 75", "Iğdır 76", "Yalova 77", "Karabük 78", "Kilis 79", "Osmaniye 80", "Düzce 81" });
            comboBox2.Location = new Point(147, 84);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 36);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana 01", "Adıyaman 02", "Afyon 03", "Ağrı 04", "Amasya 05", "Ankara 06", "Antalya 07", "Artvin 08", "Aydın 09", "Balıkesir 10", "Bilecik 11", "Bingöl 12", "Bitlis 13", "Bolu 14", "Burdur 15", "Bursa 16", "Çanakkale 17", "Çanakkale 17", "Çankırı 18", "Çorum 19", "Denizli 20", "Diyarbakır 21", "Edirne 22", "Elazığ 23", "Erzincan 24", "Erzurum 25", "Eskişehir 26", "Gaziantep 27", "Giresun 28", "Gümüşhane 29", "Hakkari 30", "Hatay 31", "Isparta 32", "Mersin 33", "İstanbul 34", "İzmir 35", "Kars 36", "Kastamonu 37", "Kayseri 38", "Kırklareli 39", "Kırşehir 40", "Kocaeli 41", "Konya 42", "Kütahya 43", "Malatya 44", "Manisa 45", "Kahramanmaraş 46", "Mardin 47", "Muğla 48", "Muş 49", "Nevşehir 50", "Niğde 51", "Ordu 52", "Rize 53", "Sakarya 54", "Samsun 55", "Siirt 56", "Sinop 57", "Sivas 58", "Tekirdağ 59", "Tokat 60", "Trabzon 61", "Tunceli 62", "Şanlıurfa 63", "Uşak 64", "Van 65", "Yozgat 66", "Zonguldak 67", "Aksaray 68", "Bayburt 69", "Karaman 70", "Kırıkkale 71", "Batman 72", "Şırnak 73", "Bartın 74", "Ardahan 75", "Iğdır 76", "Yalova 77", "Karabük 78", "Kilis 79", "Osmaniye 80", "Düzce 81" });
            comboBox1.Location = new Point(147, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 47);
            label7.Name = "label7";
            label7.Size = new Size(106, 28);
            label7.TabIndex = 5;
            label7.Text = "Nereden:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 91);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 6;
            label8.Text = "Nereye:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 192);
            label9.Name = "label9";
            label9.Size = new Size(69, 28);
            label9.TabIndex = 7;
            label9.Text = "Tarih:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 247);
            label10.Name = "label10";
            label10.Size = new Size(141, 28);
            label10.TabIndex = 8;
            label10.Text = " Kalkış Saati:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(12, 540);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(854, 200);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(866, 739);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Bilet satış";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox listBox1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox3;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox4;
        private Label label11;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button3;
        private Button button4;
        private Label label6;
    }
}