namespace ProjeYonetimi
{
    partial class KullaniciYonetme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciYonetme));
            this.geriTusu = new System.Windows.Forms.Button();
            this.kullaniciYonetbtn = new System.Windows.Forms.Button();
            this.projeYonetbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.KullaniciPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYetki = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.kullaniciSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciGetir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projeYonetPanel = new System.Windows.Forms.Panel();
            this.dgvProjeler = new System.Windows.Forms.DataGridView();
            this.getirbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtProjeDurumu = new System.Windows.Forms.ComboBox();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.guncelleProjebtn = new System.Windows.Forms.Button();
            this.KullaniciPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.projeYonetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // geriTusu
            // 
            this.geriTusu.Image = ((System.Drawing.Image)(resources.GetObject("geriTusu.Image")));
            this.geriTusu.Location = new System.Drawing.Point(12, 12);
            this.geriTusu.Name = "geriTusu";
            this.geriTusu.Size = new System.Drawing.Size(45, 45);
            this.geriTusu.TabIndex = 31;
            this.geriTusu.UseVisualStyleBackColor = true;
            this.geriTusu.Click += new System.EventHandler(this.geriTusu_Click);
            // 
            // kullaniciYonetbtn
            // 
            this.kullaniciYonetbtn.BackColor = System.Drawing.Color.Silver;
            this.kullaniciYonetbtn.Image = ((System.Drawing.Image)(resources.GetObject("kullaniciYonetbtn.Image")));
            this.kullaniciYonetbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kullaniciYonetbtn.Location = new System.Drawing.Point(12, 163);
            this.kullaniciYonetbtn.Name = "kullaniciYonetbtn";
            this.kullaniciYonetbtn.Size = new System.Drawing.Size(141, 121);
            this.kullaniciYonetbtn.TabIndex = 32;
            this.kullaniciYonetbtn.Text = "Kullanıcı Yönet";
            this.kullaniciYonetbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kullaniciYonetbtn.UseVisualStyleBackColor = false;
            this.kullaniciYonetbtn.Click += new System.EventHandler(this.kullaniciYonetbtn_Click);
            // 
            // projeYonetbtn
            // 
            this.projeYonetbtn.BackColor = System.Drawing.Color.Silver;
            this.projeYonetbtn.Image = ((System.Drawing.Image)(resources.GetObject("projeYonetbtn.Image")));
            this.projeYonetbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.projeYonetbtn.Location = new System.Drawing.Point(12, 383);
            this.projeYonetbtn.Name = "projeYonetbtn";
            this.projeYonetbtn.Size = new System.Drawing.Size(141, 121);
            this.projeYonetbtn.TabIndex = 33;
            this.projeYonetbtn.Text = "Proje Yönet";
            this.projeYonetbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.projeYonetbtn.UseVisualStyleBackColor = false;
            this.projeYonetbtn.Click += new System.EventHandler(this.projeYonetbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(251, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Yönetici Ekranına Hoşgeldiniz";
            // 
            // KullaniciPanel
            // 
            this.KullaniciPanel.Controls.Add(this.label7);
            this.KullaniciPanel.Controls.Add(this.label6);
            this.KullaniciPanel.Controls.Add(this.label5);
            this.KullaniciPanel.Controls.Add(this.label4);
            this.KullaniciPanel.Controls.Add(this.label2);
            this.KullaniciPanel.Controls.Add(this.label1);
            this.KullaniciPanel.Controls.Add(this.txtYetki);
            this.KullaniciPanel.Controls.Add(this.txtSoyad);
            this.KullaniciPanel.Controls.Add(this.txtAd);
            this.KullaniciPanel.Controls.Add(this.txtSifre);
            this.KullaniciPanel.Controls.Add(this.txtEmail);
            this.KullaniciPanel.Controls.Add(this.txtKullaniciAdi);
            this.KullaniciPanel.Controls.Add(this.guncellebtn);
            this.KullaniciPanel.Controls.Add(this.kullaniciSil);
            this.KullaniciPanel.Controls.Add(this.dataGridView1);
            this.KullaniciPanel.Controls.Add(this.kullaniciGetir);
            this.KullaniciPanel.Location = new System.Drawing.Point(190, 100);
            this.KullaniciPanel.Name = "KullaniciPanel";
            this.KullaniciPanel.Size = new System.Drawing.Size(688, 500);
            this.KullaniciPanel.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yetki :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "K_Adı :";
            // 
            // txtYetki
            // 
            this.txtYetki.Location = new System.Drawing.Point(84, 423);
            this.txtYetki.Name = "txtYetki";
            this.txtYetki.Size = new System.Drawing.Size(150, 31);
            this.txtYetki.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(84, 376);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 31);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(84, 323);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 31);
            this.txtAd.TabIndex = 7;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(84, 276);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(150, 31);
            this.txtSifre.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(84, 189);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(150, 31);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(41, 106);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(163, 34);
            this.guncellebtn.TabIndex = 3;
            this.guncellebtn.Text = "Kullanıcı Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // kullaniciSil
            // 
            this.kullaniciSil.Location = new System.Drawing.Point(51, 53);
            this.kullaniciSil.Name = "kullaniciSil";
            this.kullaniciSil.Size = new System.Drawing.Size(143, 34);
            this.kullaniciSil.TabIndex = 2;
            this.kullaniciSil.Text = "Kullanıcı Sil";
            this.kullaniciSil.UseVisualStyleBackColor = true;
            this.kullaniciSil.Click += new System.EventHandler(this.kullaniciSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(443, 500);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // kullaniciGetir
            // 
            this.kullaniciGetir.Location = new System.Drawing.Point(51, 3);
            this.kullaniciGetir.Name = "kullaniciGetir";
            this.kullaniciGetir.Size = new System.Drawing.Size(143, 34);
            this.kullaniciGetir.TabIndex = 0;
            this.kullaniciGetir.Text = "Kullanıcı Getir";
            this.kullaniciGetir.UseVisualStyleBackColor = true;
            this.kullaniciGetir.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 500);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // projeYonetPanel
            // 
            this.projeYonetPanel.Controls.Add(this.guncelleProjebtn);
            this.projeYonetPanel.Controls.Add(this.label9);
            this.projeYonetPanel.Controls.Add(this.dtpBitisTarihi);
            this.projeYonetPanel.Controls.Add(this.txtProjeDurumu);
            this.projeYonetPanel.Controls.Add(this.dtpBaslangicTarihi);
            this.projeYonetPanel.Controls.Add(this.label8);
            this.projeYonetPanel.Controls.Add(this.getirbtn);
            this.projeYonetPanel.Controls.Add(this.dgvProjeler);
            this.projeYonetPanel.Location = new System.Drawing.Point(190, 100);
            this.projeYonetPanel.Name = "projeYonetPanel";
            this.projeYonetPanel.Size = new System.Drawing.Size(688, 500);
            this.projeYonetPanel.TabIndex = 16;
            // 
            // dgvProjeler
            // 
            this.dgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeler.Location = new System.Drawing.Point(289, 3);
            this.dgvProjeler.Name = "dgvProjeler";
            this.dgvProjeler.RowHeadersWidth = 62;
            this.dgvProjeler.RowTemplate.Height = 33;
            this.dgvProjeler.Size = new System.Drawing.Size(396, 494);
            this.dgvProjeler.TabIndex = 0;
            // 
            // getirbtn
            // 
            this.getirbtn.Location = new System.Drawing.Point(122, 43);
            this.getirbtn.Name = "getirbtn";
            this.getirbtn.Size = new System.Drawing.Size(112, 34);
            this.getirbtn.TabIndex = 1;
            this.getirbtn.Text = "Getir";
            this.getirbtn.UseVisualStyleBackColor = true;
            this.getirbtn.Click += new System.EventHandler(this.getirbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Durumu :";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(0, 226);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(280, 31);
            this.dtpBaslangicTarihi.TabIndex = 3;
            // 
            // txtProjeDurumu
            // 
            this.txtProjeDurumu.FormattingEnabled = true;
            this.txtProjeDurumu.Items.AddRange(new object[] {
            "Planlama",
            "Başlangıç",
            "Analiz",
            "Tasarım",
            "Geliştirme",
            "Test ve Kalite Kontrol",
            "Dağıtım ve Uygulama",
            "Bakım ve Destek"});
            this.txtProjeDurumu.Location = new System.Drawing.Point(98, 181);
            this.txtProjeDurumu.Name = "txtProjeDurumu";
            this.txtProjeDurumu.Size = new System.Drawing.Size(182, 33);
            this.txtProjeDurumu.TabIndex = 4;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(3, 269);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(280, 31);
            this.dtpBitisTarihi.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Veri Getir :";
            // 
            // guncelleProjebtn
            // 
            this.guncelleProjebtn.Location = new System.Drawing.Point(84, 326);
            this.guncelleProjebtn.Name = "guncelleProjebtn";
            this.guncelleProjebtn.Size = new System.Drawing.Size(112, 34);
            this.guncelleProjebtn.TabIndex = 7;
            this.guncelleProjebtn.Text = "Güncelle";
            this.guncelleProjebtn.UseVisualStyleBackColor = true;
            this.guncelleProjebtn.Click += new System.EventHandler(this.guncelleProjebtn_Click);
            // 
            // KullaniciYonetme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 648);
            this.Controls.Add(this.projeYonetPanel);
            this.Controls.Add(this.KullaniciPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projeYonetbtn);
            this.Controls.Add(this.kullaniciYonetbtn);
            this.Controls.Add(this.geriTusu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciYonetme";
            this.Text = "KullaniciYonetme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciYonetme_FormClosing);
            this.KullaniciPanel.ResumeLayout(false);
            this.KullaniciPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.projeYonetPanel.ResumeLayout(false);
            this.projeYonetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button geriTusu;
        private Button kullaniciYonetbtn;
        private Button projeYonetbtn;
        private Label label3;
        private Panel KullaniciPanel;
        private PictureBox pictureBox1;
        private Button kullaniciGetir;
        private DataGridView dataGridView1;
        private Button kullaniciSil;
        private Button guncellebtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtYetki;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private TextBox txtKullaniciAdi;
        private Panel projeYonetPanel;
        private Button guncelleProjebtn;
        private Label label9;
        private DateTimePicker dtpBitisTarihi;
        private ComboBox txtProjeDurumu;
        private DateTimePicker dtpBaslangicTarihi;
        private Label label8;
        private Button getirbtn;
        private DataGridView dgvProjeler;
    }
}