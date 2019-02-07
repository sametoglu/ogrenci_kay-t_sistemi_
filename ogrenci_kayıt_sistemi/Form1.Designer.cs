namespace ogrenci_kayıt_sistemi
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
            this.components = new System.ComponentModel.Container();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_kız = new System.Windows.Forms.RadioButton();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_kan = new System.Windows.Forms.Label();
            this.txt_kan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.rd_hastalık_yok = new System.Windows.Forms.RadioButton();
            this.rd_hastalık_var = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_hastalık = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_anaadı = new System.Windows.Forms.TextBox();
            this.txt_babaadı = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_mahalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cadde = new System.Windows.Forms.TextBox();
            this.txt_sehır = new System.Windows.Forms.TextBox();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pb_ogrenci_resim = new System.Windows.Forms.PictureBox();
            this.btn_gözat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_puan = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_ikamet = new System.Windows.Forms.TextBox();
            this.tb_ikametilçe = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_dogum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ogrenci_resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(85, 56);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(98, 79);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 3;
            // 
            // txt_yas
            // 
            this.txt_yas.Location = new System.Drawing.Point(85, 134);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(100, 20);
            this.txt_yas.TabIndex = 4;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(85, 82);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "yas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "tel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tb_dogum);
            this.groupBox1.Controls.Add(this.tb_ikametilçe);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tb_ikamet);
            this.groupBox1.Controls.Add(this.rb_kız);
            this.groupBox1.Controls.Add(this.rb_erkek);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_yas);
            this.groupBox1.Controls.Add(this.lb_kan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_tcno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 308);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // rb_kız
            // 
            this.rb_kız.AutoSize = true;
            this.rb_kız.Location = new System.Drawing.Point(143, 113);
            this.rb_kız.Name = "rb_kız";
            this.rb_kız.Size = new System.Drawing.Size(39, 17);
            this.rb_kız.TabIndex = 27;
            this.rb_kız.TabStop = true;
            this.rb_kız.Text = "Kız";
            this.rb_kız.UseVisualStyleBackColor = true;
            this.rb_kız.CheckedChanged += new System.EventHandler(this.rb_kız_CheckedChanged);
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(85, 113);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(53, 17);
            this.rb_erkek.TabIndex = 26;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            this.rb_erkek.CheckedChanged += new System.EventHandler(this.rb_erkek_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "cinsiyet";
            // 
            // lb_kan
            // 
            this.lb_kan.AutoSize = true;
            this.lb_kan.Location = new System.Drawing.Point(18, 163);
            this.lb_kan.Name = "lb_kan";
            this.lb_kan.Size = new System.Drawing.Size(55, 13);
            this.lb_kan.TabIndex = 19;
            this.lb_kan.Text = "kan grubu";
            // 
            // txt_kan
            // 
            this.txt_kan.Location = new System.Drawing.Point(85, 160);
            this.txt_kan.Name = "txt_kan";
            this.txt_kan.Size = new System.Drawing.Size(100, 20);
            this.txt_kan.TabIndex = 18;
            this.txt_kan.Text = "A+ gibi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tc no";
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(85, 30);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(100, 20);
            this.txt_tcno.TabIndex = 12;
            // 
            // rd_hastalık_yok
            // 
            this.rd_hastalık_yok.AutoSize = true;
            this.rd_hastalık_yok.Location = new System.Drawing.Point(155, 132);
            this.rd_hastalık_yok.Name = "rd_hastalık_yok";
            this.rd_hastalık_yok.Size = new System.Drawing.Size(42, 17);
            this.rd_hastalık_yok.TabIndex = 23;
            this.rd_hastalık_yok.TabStop = true;
            this.rd_hastalık_yok.Text = "yok";
            this.rd_hastalık_yok.UseVisualStyleBackColor = true;
            this.rd_hastalık_yok.CheckedChanged += new System.EventHandler(this.rd_hastalık_yok_CheckedChanged);
            // 
            // rd_hastalık_var
            // 
            this.rd_hastalık_var.AutoSize = true;
            this.rd_hastalık_var.Location = new System.Drawing.Point(97, 132);
            this.rd_hastalık_var.Name = "rd_hastalık_var";
            this.rd_hastalık_var.Size = new System.Drawing.Size(40, 17);
            this.rd_hastalık_var.TabIndex = 22;
            this.rd_hastalık_var.TabStop = true;
            this.rd_hastalık_var.Text = "var";
            this.rd_hastalık_var.UseVisualStyleBackColor = true;
            this.rd_hastalık_var.CheckedChanged += new System.EventHandler(this.rd_hastalık_var_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "hastalık";
            // 
            // txt_hastalık
            // 
            this.txt_hastalık.Location = new System.Drawing.Point(97, 152);
            this.txt_hastalık.Name = "txt_hastalık";
            this.txt_hastalık.Size = new System.Drawing.Size(100, 20);
            this.txt_hastalık.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "e-maıl";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(98, 105);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_anaadı);
            this.groupBox2.Controls.Add(this.rd_hastalık_yok);
            this.groupBox2.Controls.Add(this.txt_babaadı);
            this.groupBox2.Controls.Add(this.rd_hastalık_var);
            this.groupBox2.Controls.Add(this.txt_tel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_hastalık);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_mail);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 180);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aile Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ana adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "baba adı";
            // 
            // txt_anaadı
            // 
            this.txt_anaadı.Location = new System.Drawing.Point(98, 53);
            this.txt_anaadı.Name = "txt_anaadı";
            this.txt_anaadı.Size = new System.Drawing.Size(100, 20);
            this.txt_anaadı.TabIndex = 13;
            // 
            // txt_babaadı
            // 
            this.txt_babaadı.Location = new System.Drawing.Point(98, 27);
            this.txt_babaadı.Name = "txt_babaadı";
            this.txt_babaadı.Size = new System.Drawing.Size(100, 20);
            this.txt_babaadı.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_mahalle);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_cadde);
            this.groupBox3.Controls.Add(this.txt_sehır);
            this.groupBox3.Location = new System.Drawing.Point(279, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 122);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "cadde";
            // 
            // txt_mahalle
            // 
            this.txt_mahalle.Location = new System.Drawing.Point(98, 53);
            this.txt_mahalle.Name = "txt_mahalle";
            this.txt_mahalle.Size = new System.Drawing.Size(100, 20);
            this.txt_mahalle.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "mahalle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "sehir";
            // 
            // txt_cadde
            // 
            this.txt_cadde.Location = new System.Drawing.Point(98, 79);
            this.txt_cadde.Name = "txt_cadde";
            this.txt_cadde.Size = new System.Drawing.Size(100, 20);
            this.txt_cadde.TabIndex = 13;
            // 
            // txt_sehır
            // 
            this.txt_sehır.Location = new System.Drawing.Point(98, 27);
            this.txt_sehır.Name = "txt_sehır";
            this.txt_sehır.Size = new System.Drawing.Size(100, 20);
            this.txt_sehır.TabIndex = 10;
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.Location = new System.Drawing.Point(279, 341);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(178, 41);
            this.btn_kayıt.TabIndex = 17;
            this.btn_kayıt.Text = "kaydet";
            this.btn_kayıt.UseVisualStyleBackColor = true;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Bilgi Ekranı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_ogrenci_resim
            // 
            this.pb_ogrenci_resim.Location = new System.Drawing.Point(549, 18);
            this.pb_ogrenci_resim.Name = "pb_ogrenci_resim";
            this.pb_ogrenci_resim.Size = new System.Drawing.Size(171, 176);
            this.pb_ogrenci_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ogrenci_resim.TabIndex = 20;
            this.pb_ogrenci_resim.TabStop = false;
            // 
            // btn_gözat
            // 
            this.btn_gözat.Location = new System.Drawing.Point(549, 204);
            this.btn_gözat.Name = "btn_gözat";
            this.btn_gözat.Size = new System.Drawing.Size(171, 41);
            this.btn_gözat.TabIndex = 21;
            this.btn_gözat.Text = "Gözat";
            this.btn_gözat.UseVisualStyleBackColor = true;
            this.btn_gözat.Click += new System.EventHandler(this.btn_gözat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(549, 266);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(171, 41);
            this.btn_ara.TabIndex = 22;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click_1);
            // 
            // btn_puan
            // 
            this.btn_puan.Location = new System.Drawing.Point(549, 341);
            this.btn_puan.Name = "btn_puan";
            this.btn_puan.Size = new System.Drawing.Size(171, 41);
            this.btn_puan.TabIndex = 23;
            this.btn_puan.Text = "puan";
            this.btn_puan.UseVisualStyleBackColor = true;
            this.btn_puan.Click += new System.EventHandler(this.btn_puan_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "ikamet";
            // 
            // tb_ikamet
            // 
            this.tb_ikamet.Location = new System.Drawing.Point(85, 254);
            this.tb_ikamet.Name = "tb_ikamet";
            this.tb_ikamet.Size = new System.Drawing.Size(100, 20);
            this.tb_ikamet.TabIndex = 28;
            this.tb_ikamet.TextChanged += new System.EventHandler(this.tb_ikamet_TextChanged);
            // 
            // tb_ikametilçe
            // 
            this.tb_ikametilçe.Location = new System.Drawing.Point(85, 281);
            this.tb_ikametilçe.Name = "tb_ikametilçe";
            this.tb_ikametilçe.Size = new System.Drawing.Size(100, 20);
            this.tb_ikametilçe.TabIndex = 30;
            this.tb_ikametilçe.Text = "ilce";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "dogum yeri";
            // 
            // tb_dogum
            // 
            this.tb_dogum.Location = new System.Drawing.Point(85, 192);
            this.tb_dogum.Name = "tb_dogum";
            this.tb_dogum.Size = new System.Drawing.Size(100, 20);
            this.tb_dogum.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 407);
            this.Controls.Add(this.btn_puan);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_gözat);
            this.Controls.Add(this.pb_ogrenci_resim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ogrenci_resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_anaadı;
        private System.Windows.Forms.TextBox txt_babaadı;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cadde;
        private System.Windows.Forms.TextBox txt_sehır;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_mahalle;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rd_hastalık_yok;
        private System.Windows.Forms.RadioButton rd_hastalık_var;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_hastalık;
        private System.Windows.Forms.Label lb_kan;
        private System.Windows.Forms.TextBox txt_kan;
        private System.Windows.Forms.PictureBox pb_ogrenci_resim;
        private System.Windows.Forms.Button btn_gözat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rb_kız;
        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_puan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_ikamet;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox tb_ikametilçe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_dogum;
    }
}

