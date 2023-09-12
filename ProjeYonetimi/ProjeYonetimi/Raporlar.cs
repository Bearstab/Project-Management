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
    public partial class Raporlar : Form
    {
        private AnaMenu oldform;

        string connectionString = "Host=localhost;Port=5432;Database=ProjeYonetimi;Username=postgres;Password=23271973";

        public Raporlar(AnaMenu anaMenu)
        {
            InitializeComponent();
            oldform = anaMenu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            yeniRaporPanel.Visible = false;
            raporlarPanel.Visible = false;
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

        private void Raporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // Sadece kullanıcı tarafından kapatıldığında işlem yapılacak
            {
                Application.Exit(); // Uygulamayı tamamen kapat

            }
        }

        private void LoadProjeler()
        {
            // Veritabanı bağlantısı için gerekli bilgileri sağlayın


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
                            projelerComboBox.Items.Add(new ProjeItem(reader["proje_adi"].ToString(), int.Parse(reader["proje_id"].ToString())));
                        }
                    }
                }
            }
        }

        private void projelerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (projelerComboBox.SelectedItem != null)
            {
                ProjeItem selectedProje = (ProjeItem)projelerComboBox.SelectedItem;
                int projeId = selectedProje.ProjeId;
                // Seçilen proje ID'sini kullanarak işlemler yapabilirsiniz
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

        private void Raporlar_Load(object sender, EventArgs e)
        {
            LoadProjeler();
            LoadRaporProjeler();
        }

        private void raporOlustur_Click(object sender, EventArgs e)
        {
            // Seçilen proje adının ProjeId'sini alın
            ProjeItem secilenProje = (ProjeItem)projelerComboBox.SelectedItem;
            int projeId = secilenProje.ProjeId;

            // Diğer gerekli verileri alın
            DateTime raporTarihi = dateTimePicker1.Value;
            
            string raporTipi = comboBox2.Text;
            string raporIcerigi = richTextBox1.Text;

            // Veritabanına kayıt ekleme işlemi
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO raporlar (proje_id, rapor_tipi, rapor_tarihi, rapor_icerigi) " +
                                          "VALUES (@projeId, @raporTipi, @raporTarihi, @raporIcerigi)";
                    command.Parameters.AddWithValue("@projeId", projeId);
                    command.Parameters.AddWithValue("@raporTipi", raporTipi);
                    command.Parameters.AddWithValue("@raporTarihi", raporTarihi);
                    command.Parameters.AddWithValue("@raporIcerigi", raporIcerigi);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Rapor başarıyla kaydedildi.");
        }

        private void btnraporOlustur_Click(object sender, EventArgs e)
        {
            if (raporlarPanel.Visible == true)
            {
                raporlarPanel.Visible = false;
            }
            yeniRaporPanel.Visible = true;
        }

        private void raporGetir_Click(object sender, EventArgs e)
        {
            if (yeniRaporPanel.Visible == true)
            {
                yeniRaporPanel.Visible = false;
            }
            raporlarPanel.Visible=true;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // Seçilen proje adının ProjeId'sini alın
            ProjeItem secilenProje = (ProjeItem)comboBoxProjeAdi.SelectedItem;
            int projeId = secilenProje.ProjeId;

            // Raporları veritabanından getir
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM raporlar WHERE proje_id = @projeId";
                    command.Parameters.AddWithValue("@projeId", projeId);

                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        var dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        // DataGridView'e verileri aktar
                        dataGridViewRaporlar.DataSource = dataSet.Tables[0];
                    }
                }
            }
        }

        private void LoadRaporProjeler()
        {
            // Veritabanı bağlantısı için gerekli bilgileri sağlayın


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
                            comboBoxProjeAdi.Items.Add(new ProjeItem(reader["proje_adi"].ToString(), int.Parse(reader["proje_id"].ToString())));
                        }
                    }
                }
            }
        }
    }
}
