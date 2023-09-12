namespace ProjeYonetimi
{
    partial class KullaniciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKayit));
            this.geriTusu = new System.Windows.Forms.Button();
            this.kayitOl = new System.Windows.Forms.Button();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.kullaniciEmailtxt = new System.Windows.Forms.TextBox();
            this.kullaniciAditxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yetkiComboBox = new System.Windows.Forms.ComboBox();
            this.sifretxt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // geriTusu
            // 
            this.geriTusu.Image = ((System.Drawing.Image)(resources.GetObject("geriTusu.Image")));
            this.geriTusu.Location = new System.Drawing.Point(12, 12);
            this.geriTusu.Name = "geriTusu";
            this.geriTusu.Size = new System.Drawing.Size(45, 45);
            this.geriTusu.TabIndex = 44;
            this.geriTusu.UseVisualStyleBackColor = true;
            this.geriTusu.Click += new System.EventHandler(this.geriTusu_Click);
            // 
            // kayitOl
            // 
            this.kayitOl.BackColor = System.Drawing.Color.Silver;
            this.kayitOl.Image = ((System.Drawing.Image)(resources.GetObject("kayitOl.Image")));
            this.kayitOl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kayitOl.Location = new System.Drawing.Point(270, 228);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(141, 121);
            this.kayitOl.TabIndex = 43;
            this.kayitOl.Text = "Kayıt Ol";
            this.kayitOl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kayitOl.UseVisualStyleBackColor = false;
            this.kayitOl.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(500, 179);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(150, 31);
            this.soyadtxt.TabIndex = 42;
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(500, 133);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(150, 31);
            this.adtxt.TabIndex = 41;
            // 
            // kullaniciEmailtxt
            // 
            this.kullaniciEmailtxt.Location = new System.Drawing.Point(500, 82);
            this.kullaniciEmailtxt.Name = "kullaniciEmailtxt";
            this.kullaniciEmailtxt.Size = new System.Drawing.Size(150, 31);
            this.kullaniciEmailtxt.TabIndex = 40;
            // 
            // kullaniciAditxt
            // 
            this.kullaniciAditxt.Location = new System.Drawing.Point(230, 83);
            this.kullaniciAditxt.Name = "kullaniciAditxt";
            this.kullaniciAditxt.Size = new System.Drawing.Size(150, 31);
            this.kullaniciAditxt.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(128, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 27);
            this.label10.TabIndex = 36;
            this.label10.Text = "Rütbe :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(398, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 27);
            this.label9.TabIndex = 35;
            this.label9.Text = "Soyad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(434, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(128, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(398, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(230, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kayıt olma Ekranı";
            // 
            // yetkiComboBox
            // 
            this.yetkiComboBox.FormattingEnabled = true;
            this.yetkiComboBox.Location = new System.Drawing.Point(230, 179);
            this.yetkiComboBox.Name = "yetkiComboBox";
            this.yetkiComboBox.Size = new System.Drawing.Size(150, 33);
            this.yetkiComboBox.TabIndex = 45;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(230, 132);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(150, 31);
            this.sifretxt.TabIndex = 46;

            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 362);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.yetkiComboBox);
            this.Controls.Add(this.geriTusu);
            this.Controls.Add(this.kayitOl);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.kullaniciEmailtxt);
            this.Controls.Add(this.kullaniciAditxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "KullaniciKayit";
            this.Text = "KullaniciKayit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciKayit_FormClosed);
            this.Load += new System.EventHandler(this.KullaniciKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button geriTusu;
        private Button kayitOl;
        private TextBox soyadtxt;
        private TextBox adtxt;
        private TextBox kullaniciEmailtxt;
        private TextBox kullaniciAditxt;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox yetkiComboBox;
        private MaskedTextBox sifretxt;
    }
}