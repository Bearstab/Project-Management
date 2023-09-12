using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProjeYonetimi
{

    public partial class YoneticiGirisi : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973";
        private KullaniciGirisi oldform;
        public YoneticiGirisi(KullaniciGirisi kullaniciGirisi)
        {
            InitializeComponent();
            oldform = kullaniciGirisi;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            sifretxt.UseSystemPasswordChar = true;
        }
        private void YoneticiGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                Application.Exit(); // Uygulamayı tamamen kapat

            }
        }
        private void yoneticiLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAditxt.Text;
            string sifre = sifretxt.Text;

            // Veritabanı bağlantısını oluştur
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString)) // veya NpgsqlConnection (PostgreSQL için)
            {
                try
                {
                    connection.Open();
                    // Kullanıcı girişini doğrulamak için veritabanında sorgu çalıştır
                    string query = "SELECT COUNT(*) FROM admin WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int result = reader.GetInt32(0);
                                if (result > 0)
                                {
                                    MessageBox.Show("Giriş başarılı Admin Paneline yönlendiriliyorsunuz -->");
                                    KullaniciYonetme kullaniciYonetme = new KullaniciYonetme(this);
                                    kullaniciYonetme.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    // Kullanıcı doğrulanamadı, hata mesajı göster
                                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda işleme devam edilemez
                    MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }
        private void geriTusu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Geri dönmek istiyor musunuz?", "Geri Dön", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Geri dönme işlemini gerçekleştirecek kodları burada yazıcak               

                oldform.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
