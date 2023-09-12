namespace ProjeYonetimi
{
    partial class YoneticiGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisi));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kullaniciAditxt = new System.Windows.Forms.TextBox();
            this.yoneticiLogin = new System.Windows.Forms.Button();
            this.geriTusu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(150, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yönetici Giriş Ekranına Hoşgeldiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(135, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(410, 184);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(189, 31);
            this.sifretxt.TabIndex = 26;
            // 
            // kullaniciAditxt
            // 
            this.kullaniciAditxt.Location = new System.Drawing.Point(410, 126);
            this.kullaniciAditxt.Name = "kullaniciAditxt";
            this.kullaniciAditxt.Size = new System.Drawing.Size(189, 31);
            this.kullaniciAditxt.TabIndex = 25;
            // 
            // yoneticiLogin
            // 
            this.yoneticiLogin.BackColor = System.Drawing.Color.Silver;
            this.yoneticiLogin.Image = ((System.Drawing.Image)(resources.GetObject("yoneticiLogin.Image")));
            this.yoneticiLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.yoneticiLogin.Location = new System.Drawing.Point(298, 262);
            this.yoneticiLogin.Name = "yoneticiLogin";
            this.yoneticiLogin.Size = new System.Drawing.Size(141, 121);
            this.yoneticiLogin.TabIndex = 29;
            this.yoneticiLogin.Text = "Yönetici Girisi";
            this.yoneticiLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yoneticiLogin.UseVisualStyleBackColor = false;
            this.yoneticiLogin.Click += new System.EventHandler(this.yoneticiLogin_Click);
            // 
            // geriTusu
            // 
            this.geriTusu.Image = ((System.Drawing.Image)(resources.GetObject("geriTusu.Image")));
            this.geriTusu.Location = new System.Drawing.Point(12, 12);
            this.geriTusu.Name = "geriTusu";
            this.geriTusu.Size = new System.Drawing.Size(45, 45);
            this.geriTusu.TabIndex = 30;
            this.geriTusu.UseVisualStyleBackColor = true;
            this.geriTusu.Click += new System.EventHandler(this.geriTusu_Click);
            // 
            // YoneticiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 423);
            this.Controls.Add(this.geriTusu);
            this.Controls.Add(this.yoneticiLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullaniciAditxt);
            this.Controls.Add(this.label3);
            this.Name = "YoneticiGirisi";
            this.Text = "YoneticiGirisi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YoneticiGirisi_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox sifretxt;
        private TextBox kullaniciAditxt;
        private Button yoneticiLogin;
        private Button geriTusu;
    }
}