namespace Etut
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEtutOlustur = new System.Windows.Forms.Button();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.CmbOgretmen = new System.Windows.Forms.ComboBox();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnOgrenciEkle = new System.Windows.Forms.Button();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSınıf = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnOgretmenEkle = new System.Windows.Forms.Button();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.TxtOgrtAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnDersEkle = new System.Windows.Forms.Button();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEtutOlustur);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.CmbOgretmen);
            this.groupBox1.Controls.Add(this.CmbDers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEtutOlustur
            // 
            this.BtnEtutOlustur.Location = new System.Drawing.Point(139, 191);
            this.BtnEtutOlustur.Name = "BtnEtutOlustur";
            this.BtnEtutOlustur.Size = new System.Drawing.Size(163, 28);
            this.BtnEtutOlustur.TabIndex = 8;
            this.BtnEtutOlustur.Text = "Etüt Oluştur";
            this.BtnEtutOlustur.UseVisualStyleBackColor = true;
            this.BtnEtutOlustur.Click += new System.EventHandler(this.BtnEtutOlustur_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(114, 155);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(222, 30);
            this.MskSaat.TabIndex = 7;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(114, 115);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(222, 30);
            this.MskTarih.TabIndex = 6;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // CmbOgretmen
            // 
            this.CmbOgretmen.FormattingEnabled = true;
            this.CmbOgretmen.Location = new System.Drawing.Point(116, 66);
            this.CmbOgretmen.Name = "CmbOgretmen";
            this.CmbOgretmen.Size = new System.Drawing.Size(220, 32);
            this.CmbOgretmen.TabIndex = 5;
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(116, 27);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(220, 32);
            this.CmbDers.TabIndex = 4;
            this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğretmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 30);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(136, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 30);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Öğrenci:";
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.Location = new System.Drawing.Point(146, 112);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(146, 32);
            this.BtnEtutVer.TabIndex = 6;
            this.BtnEtutVer.Text = "Etüt Ver";
            this.BtnEtutVer.UseVisualStyleBackColor = true;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Etüt Id:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(965, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnOgrenciEkle);
            this.groupBox4.Controls.Add(this.TxtMail);
            this.groupBox4.Controls.Add(this.MskTelefon);
            this.groupBox4.Controls.Add(this.TxtSınıf);
            this.groupBox4.Controls.Add(this.TxtSoyad);
            this.groupBox4.Controls.Add(this.TxtAd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(734, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 245);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // BtnOgrenciEkle
            // 
            this.BtnOgrenciEkle.Location = new System.Drawing.Point(94, 204);
            this.BtnOgrenciEkle.Name = "BtnOgrenciEkle";
            this.BtnOgrenciEkle.Size = new System.Drawing.Size(143, 31);
            this.BtnOgrenciEkle.TabIndex = 11;
            this.BtnOgrenciEkle.Text = "Öğrenci Ekle";
            this.BtnOgrenciEkle.UseVisualStyleBackColor = true;
            this.BtnOgrenciEkle.Click += new System.EventHandler(this.BtnOgrenciEkle_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(94, 168);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(143, 30);
            this.TxtMail.TabIndex = 10;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(94, 132);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(143, 30);
            this.MskTelefon.TabIndex = 9;
            // 
            // TxtSınıf
            // 
            this.TxtSınıf.Location = new System.Drawing.Point(94, 96);
            this.TxtSınıf.Name = "TxtSınıf";
            this.TxtSınıf.Size = new System.Drawing.Size(143, 30);
            this.TxtSınıf.TabIndex = 8;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(94, 60);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(143, 30);
            this.TxtSoyad.TabIndex = 7;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(94, 23);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(143, 30);
            this.TxtAd.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Sınıf:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Soyad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(49, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ad:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(983, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 244);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fotoğraf Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnOgretmenEkle);
            this.groupBox6.Controls.Add(this.CmbBrans);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.TxtOgrtSoyad);
            this.groupBox6.Controls.Add(this.TxtOgrtAd);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(983, 256);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(228, 220);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // BtnOgretmenEkle
            // 
            this.BtnOgretmenEkle.Location = new System.Drawing.Point(77, 131);
            this.BtnOgretmenEkle.Name = "BtnOgretmenEkle";
            this.BtnOgretmenEkle.Size = new System.Drawing.Size(143, 31);
            this.BtnOgretmenEkle.TabIndex = 14;
            this.BtnOgretmenEkle.Text = "Öğretmen Ekle";
            this.BtnOgretmenEkle.UseVisualStyleBackColor = true;
            this.BtnOgretmenEkle.Click += new System.EventHandler(this.BtnOgretmenEkle_Click);
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(77, 93);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(145, 32);
            this.CmbBrans.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Branş:";
            // 
            // TxtOgrtSoyad
            // 
            this.TxtOgrtSoyad.Location = new System.Drawing.Point(77, 57);
            this.TxtOgrtSoyad.Name = "TxtOgrtSoyad";
            this.TxtOgrtSoyad.Size = new System.Drawing.Size(143, 30);
            this.TxtOgrtSoyad.TabIndex = 11;
            // 
            // TxtOgrtAd
            // 
            this.TxtOgrtAd.Location = new System.Drawing.Point(77, 20);
            this.TxtOgrtAd.Name = "TxtOgrtAd";
            this.TxtOgrtAd.Size = new System.Drawing.Size(143, 30);
            this.TxtOgrtAd.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "Soyad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(32, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = "Ad:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BtnDersEkle);
            this.groupBox7.Controls.Add(this.TxtDersAd);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(373, 170);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(355, 87);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // BtnDersEkle
            // 
            this.BtnDersEkle.Location = new System.Drawing.Point(261, 27);
            this.BtnDersEkle.Name = "BtnDersEkle";
            this.BtnDersEkle.Size = new System.Drawing.Size(88, 30);
            this.BtnDersEkle.TabIndex = 10;
            this.BtnDersEkle.Text = "Ders Ekle";
            this.BtnDersEkle.UseVisualStyleBackColor = true;
            this.BtnDersEkle.Click += new System.EventHandler(this.BtnDersEkle_Click);
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(90, 27);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(165, 30);
            this.TxtDersAd.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(2, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ders Adı:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1223, 484);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEtutOlustur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnOgrenciEkle;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtSınıf;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnDersEkle;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtOgrtSoyad;
        private System.Windows.Forms.TextBox TxtOgrtAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnOgretmenEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

