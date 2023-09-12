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
    
    public partial class KullaniciYonetme : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973"; //Sql sunucumuza bağlanma metni
        private YoneticiGirisi oldform;
        public KullaniciYonetme(YoneticiGirisi yoneticiGirisi)
        {
            //Bu kod satırında formumuzun genel özelliklerini belirtiyoruz. Ekstra yapılar üzerinde değişiklik yapıyoruz
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            oldform = yoneticiGirisi;
            KullaniciPanel.Visible = false;
            projeYonetPanel.Visible = false;

        }

        private void geriTusu_Click(object sender, EventArgs e)
        {
            //Burada Geri tuşu kodlarını yazıyoruz
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

        private void KullaniciYonetme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                Application.Exit(); // Uygulamayı tamamen kapat

            }
        }

        private void kullaniciYonetbtn_Click(object sender, EventArgs e)
        {
            if (KullaniciPanel.Visible == true)
            {
                KullaniciPanel.Visible = false;
            }
            else if (projeYonetPanel.Visible == true)
            {
                projeYonetPanel.Visible = false;
            }
            else
            {
                KullaniciPanel.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını oluştur
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıları getirmek için sorguyu hazırla
                    string query = "SELECT * FROM kullanicilar";

                    // NpgsqlDataAdapter kullanarak verileri al
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri ata
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda işleme devam edilemez
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
        }

        private void kullaniciSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int kullaniciId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["user_id"].Value);

                // Veritabanından sil
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        // Silme sorgusunu hazırla
                        string query = "DELETE FROM kullanicilar WHERE user_id = @kullaniciId";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                            // Sorguyu çalıştır
                            int affectedRows = command.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                // Silme işlemi başarılı oldu, DataGridView'den de sil
                                dataGridView1.Rows.RemoveAt(rowIndex);
                                MessageBox.Show("Kullanıcı başarıyla silindi.");
                            }
                            else
                            {
                                // Silme işlemi başarısız
                                MessageBox.Show("Kullanıcı silinirken bir hata oluştu.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda işleme devam edilemez
                    MessageBox.Show("Veritabanına erişirken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir kullanıcı seçin.");
            }
        }
        

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int kullaniciId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);

                // TextBox'lardan güncellenmiş verileri al
                string yeniKullaniciAdi = txtKullaniciAdi.Text;
                string yeniEmail = txtEmail.Text;
                string yeniSifre = txtSifre.Text;
                string yeniAd = txtAd.Text;
                string yeniSoyad = txtSoyad.Text;
                string yeniYetki = txtYetki.Text;


                // Veritabanında güncelleme işlemi
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE kullanicilar SET kullanici_adi = @KullaniciAdi, email = @Email, sifre = @Sifre, ad = @Ad, soyad = @Soyad, yetkisi = @Yetki  WHERE user_id = @KullaniciId";
                        command.Parameters.AddWithValue("@KullaniciAdi", yeniKullaniciAdi);
                        command.Parameters.AddWithValue("@Email", yeniEmail);
                        command.Parameters.AddWithValue("@Sifre", yeniSifre);
                        command.Parameters.AddWithValue("@Ad", yeniAd);
                        command.Parameters.AddWithValue("@Soyad", yeniSoyad);
                        command.Parameters.AddWithValue("@Yetki", yeniYetki);

                        command.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                        command.ExecuteNonQuery();
                    }
                }

                // Verileri güncelleme
                selectedRow.Cells["kullanici_adi"].Value = yeniKullaniciAdi;
                selectedRow.Cells["email"].Value = yeniEmail;
                selectedRow.Cells["sifre"].Value = yeniSifre;
                selectedRow.Cells["ad"].Value = yeniAd;
                selectedRow.Cells["soyad"].Value = yeniSoyad;
                selectedRow.Cells["yetkisi"].Value = yeniYetki;


                MessageBox.Show("Veriler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // Verileri TextBox'lara yerleştirme
                txtKullaniciAdi.Text = selectedRow.Cells["kullanici_adi"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtSifre.Text = selectedRow.Cells["sifre"].Value.ToString();
                txtAd.Text = selectedRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = selectedRow.Cells["soyad"].Value.ToString();
                txtYetki.Text = selectedRow.Cells["yetkisi"].Value.ToString();
            }
        }

        private void projeYonetbtn_Click(object sender, EventArgs e)
        {
            if (projeYonetPanel.Visible == true)
            {
                projeYonetPanel.Visible = false;
            }
            else if (KullaniciPanel.Visible == true)
            {
                KullaniciPanel.Visible = false;
            }
            else
            {
                projeYonetPanel.Visible = true;
            }
        }

        private void guncelleProjebtn_Click(object sender, EventArgs e)
        {
            // Seçilen projenin bilgilerini al
            int projeId = Convert.ToInt32(dgvProjeler.SelectedRows[0].Cells["proje_id"].Value);
            string durum = txtProjeDurumu.SelectedItem.ToString();
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
            DateTime bitisTarihi = dtpBitisTarihi.Value;

            // Veritabanında projeyi güncelle
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE projeler SET durum = @Durum, baslangic_tarihi = @BaslangicTarihi, bitis_tarihi = @BitisTarihi WHERE proje_id = @ProjeId";
                    command.Parameters.AddWithValue("@Durum", durum);
                    command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    command.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
                    command.Parameters.AddWithValue("@ProjeId", projeId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proje güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Proje güncellenirken bir hata oluştu.");
                    }
                }
            }
        }

        private void getirbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını oluştur
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıları getirmek için sorguyu hazırla
                    string query = "SELECT * FROM projeler";

                    // NpgsqlDataAdapter kullanarak verileri al
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri ata
                    dgvProjeler.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda işleme devam edilemez
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
