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
    public partial class Gorevlerim : Form
    {
        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973";
        private AnaMenu oldform;
        public Gorevlerim(AnaMenu anaMenu)
        {
            InitializeComponent();
            oldform = anaMenu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gorevOlusturPanel.Visible = false;
            gorevPanel.Visible = false;
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

        private void btnraporOlustur_Click(object sender, EventArgs e)
        {
            if (gorevPanel.Visible == true)
            {
                gorevPanel.Visible = false;
            }
            gorevOlusturPanel.Visible = true;
        }
       

        private void Gorevlerim_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                Application.Exit(); // Uygulamayı tamamen kapat

            }
        }

        private void KullaniciAdlariniDoldur()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT user_id, kullanici_adi FROM kullanicilar";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Her bir kullanıcı adını ComboBox'lara ekleyin
                            comboBoxSorumluKullanici.Items.Add(new KullaniciItem(reader["kullanici_adi"].ToString(), int.Parse(reader["user_id"].ToString())));
                            comboBoxKullanici.Items.Add(new KullaniciItem(reader["kullanici_adi"].ToString(), int.Parse(reader["user_id"].ToString())));
                        }
                    }
                }
            }
        }

        private void ProjeAdlariniDoldur()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT proje_id, proje_adi FROM projeler";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Her bir proje adını ComboBox'a ekleyin
                            comboBoxProje.Items.Add(new ProjeItem(reader["proje_adi"].ToString(), int.Parse(reader["proje_id"].ToString())));
                        }
                    }
                }
            }
        }
        public class ProjeItem
        {
            public string ProjeAdi { get; set; }
            public int ProjeId { get; set; }

            public ProjeItem(string projeAdi, int projeId)
            {
                ProjeAdi = projeAdi;
                ProjeId = projeId;
            }

            public override string ToString()
            {
                return ProjeAdi;
            }
        }

        public class KullaniciItem
        {
            public string KullaniciAdi { get; set; }
            public int KullaniciId { get; set; }

            public KullaniciItem(string kullaniciAdi, int kullaniciId)
            {
                KullaniciAdi = kullaniciAdi;
                KullaniciId = kullaniciId;
            }

            public override string ToString()
            {
                return KullaniciAdi;
            }
        }

        private void Gorevlerim_Load(object sender, EventArgs e)
        {
            ProjeAdlariniDoldur();
            KullaniciAdlariniDoldur();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            string gorevAdi = textBoxGorevAdi.Text;
            int projeId = ((ProjeItem)comboBoxProje.SelectedItem).ProjeId;
            int kullaniciId = ((KullaniciItem)comboBoxSorumluKullanici.SelectedItem).KullaniciId;
            string oncelik = comboBoxOncelik.SelectedItem.ToString();
            DateTime baslangicTarihi = dateTimePickerBaslangicTarihi.Value;
            DateTime bitisTarihi = dateTimePickerBitisTarihi.Value;
            string durumu = comboBoxDurumu.SelectedItem.ToString();

            // Görevleri veritabanına ekleme işlemleri burada gerçekleştirilir
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO gorevler (gorev_adi, proje_id, sorumlu_kullanici_id, oncelik, baslangic_tarihi, bitis_tarihi, durumu) VALUES (@gorevAdi, @projeId, @kullaniciId, @oncelik, @baslangicTarihi, @bitisTarihi, @durumu)";
                    command.Parameters.AddWithValue("@gorevAdi", gorevAdi);
                    command.Parameters.AddWithValue("@projeId", projeId);
                    command.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    command.Parameters.AddWithValue("@oncelik", oncelik);
                    command.Parameters.AddWithValue("@baslangicTarihi", baslangicTarihi);
                    command.Parameters.AddWithValue("@bitisTarihi", bitisTarihi);
                    command.Parameters.AddWithValue("@durumu", durumu);
                    command.ExecuteNonQuery();
                }
            }

            // Örnek olarak, ekleme işlemi tamamlandığında bir mesaj gösterelim
            MessageBox.Show("Görev oluşturuldu!");
        }

        private void gorevlerbtn_Click(object sender, EventArgs e)
        {
            if (gorevOlusturPanel.Visible == true)
            {
                gorevOlusturPanel.Visible = false;
            }
            gorevPanel.Visible = true;
        }

        private void gorevGetirbtn_Click(object sender, EventArgs e)
        {           
            

            // Seçilen kullanıcının kimlik bilgisini al
            int kullaniciId = ((KullaniciItem)comboBoxKullanici.SelectedItem).KullaniciId;

            // Veritabanından kullanıcının görevlerini getir
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM gorevler WHERE sorumlu_kullanici_id = @KullaniciId";
                    command.Parameters.AddWithValue("@KullaniciId", kullaniciId);

                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        // Verileri DataSet'e doldur
                        var dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        // DataSet'teki verileri DataGridView'e aktar
                        dgvGorevler.DataSource = dataSet.Tables[0];
                    }
                }
            }
        }
    }
}
