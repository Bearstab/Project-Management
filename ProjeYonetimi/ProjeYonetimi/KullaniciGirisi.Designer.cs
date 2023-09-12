namespace ProjeYonetimi
{
    partial class KullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisi));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kullaniciAditxt = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.kullaniciLogin = new System.Windows.Forms.Button();
            this.yoneticiLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(144, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(419, 162);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(189, 31);
            this.sifretxt.TabIndex = 22;
            // 
            // kullaniciAditxt
            // 
            this.kullaniciAditxt.Location = new System.Drawing.Point(419, 104);
            this.kullaniciAditxt.Name = "kullaniciAditxt";
            this.kullaniciAditxt.Size = new System.Drawing.Size(189, 31);
            this.kullaniciAditxt.TabIndex = 21;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Silver;
            this.register.Image = ((System.Drawing.Image)(resources.GetObject("register.Image")));
            this.register.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.register.Location = new System.Drawing.Point(48, 246);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(141, 121);
            this.register.TabIndex = 20;
            this.register.Text = "Kayıt Ol";
            this.register.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // kullaniciLogin
            // 
            this.kullaniciLogin.BackColor = System.Drawing.Color.Silver;
            this.kullaniciLogin.Image = ((System.Drawing.Image)(resources.GetObject("kullaniciLogin.Image")));
            this.kullaniciLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kullaniciLogin.Location = new System.Drawing.Point(438, 244);
            this.kullaniciLogin.Name = "kullaniciLogin";
            this.kullaniciLogin.Size = new System.Drawing.Size(141, 121);
            this.kullaniciLogin.TabIndex = 19;
            this.kullaniciLogin.Text = "Kullanıcı Girişi";
            this.kullaniciLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kullaniciLogin.UseVisualStyleBackColor = false;
            this.kullaniciLogin.Click += new System.EventHandler(this.kullaniciLogin_Click);
            // 
            // yoneticiLogin
            // 
            this.yoneticiLogin.BackColor = System.Drawing.Color.Silver;
            this.yoneticiLogin.Image = ((System.Drawing.Image)(resources.GetObject("yoneticiLogin.Image")));
            this.yoneticiLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.yoneticiLogin.Location = new System.Drawing.Point(195, 246);
            this.yoneticiLogin.Name = "yoneticiLogin";
            this.yoneticiLogin.Size = new System.Drawing.Size(141, 121);
            this.yoneticiLogin.TabIndex = 18;
            this.yoneticiLogin.Text = "Yönetici Girisi";
            this.yoneticiLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.yoneticiLogin.UseVisualStyleBackColor = false;
            this.yoneticiLogin.Click += new System.EventHandler(this.yoneticiLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Proje Yönetim Sistemine Hoşgeldiniz";
            // 
            // KullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullaniciAditxt);
            this.Controls.Add(this.register);
            this.Controls.Add(this.kullaniciLogin);
            this.Controls.Add(this.yoneticiLogin);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGirisi";
            this.Text = "KullaniciGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label2;
        private TextBox sifretxt;
        private TextBox kullaniciAditxt;
        private Button register;
        private Button kullaniciLogin;
        private Button yoneticiLogin;
        private Label label1;
    }
}