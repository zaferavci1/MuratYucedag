using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSınavogrenciEntities db = new DbSınavogrenciEntities();
        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbSınavogrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT * FROM tbldersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNOTLAR
                        select new
                        {
                            item.NOTID,
                            item.TBLOGRENCI.AD,
                            item.TBLOGRENCI.SOYAD,
                            item.TBLDERSLER.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI t = new TBLOGRENCI(); //tbl ogrenci artık bir sınıf
            t.AD = txtOgrAd.Text;
            t.SOYAD = txtOgrSoyad.Text;
            db.TBLOGRENCI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Listeye Eklenmiştir");
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            TBLDERSLER ders = new TBLDERSLER();
            ders.DERSAD = txtDersAd.Text;
            db.TBLDERSLER.Add(ders);
            db.SaveChanges();
            MessageBox.Show("Ders Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrId.Text);
            var x = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("öğrenci sistemden silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrId.Text);
            var x = db.TBLOGRENCI.Find(id);
            x.AD = Convert.ToString(txtOgrAd.Text);
            x.SOYAD = Convert.ToString(txtOgrSoyad.Text);
            x.FOTOGRAF = Convert.ToString(txtOgrFoto.Text);
            db.SaveChanges();
            MessageBox.Show("Öğrenci bilgileri güncellendi");
        }

        private void btnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrId.Text);
            dataGridView1.DataSource = db.TBLOGRENCI.Where(x => x.ID == id).ToList();
        }

        private void txtOgrAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrAd.Text;
            var value = from item in db.TBLOGRENCI
                        where item.AD.Contains(aranan)
                        select item;
            dataGridView1.DataSource = value.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (adaGoreSirala.Checked == true)
            {
                List<TBLOGRENCI> liste1 = db.TBLOGRENCI.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton1.Checked == true)
            {
                List<TBLOGRENCI> liste2 = db.TBLOGRENCI.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton2.Checked == true)
            {
                List<TBLOGRENCI> liste3 = db.TBLOGRENCI.OrderBy(p => p.ID).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (radioButton3.Checked == true)
            {
                List<TBLOGRENCI> liste4 = db.TBLOGRENCI.Where(p => p.AD.StartsWith("z")).ToList();
                dataGridView1.DataSource = liste4;
            }
            if (radioButton4.Checked == true)
            {
                List<TBLOGRENCI> liste5 = db.TBLOGRENCI.Where(p => p.AD.EndsWith("n")).ToList();
                dataGridView1.DataSource = liste5;
            }
            if (radioButton5.Checked == true)
            {
                bool deger = db.TBLKULUBLER.Any();
                MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton6.Checked == true)
            {
                int toplam = db.TBLOGRENCI.Count();
                MessageBox.Show(toplam.ToString(), "Toplam öğrenci sayisi: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton7.Checked == true)
            {
                var toplam = db.TBLNOTLAR.Sum(x => x.SINAV1);
                MessageBox.Show(toplam.ToString(), "Toplam sınav 1: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton8.Checked == true)
            {
                var ortalama = db.TBLNOTLAR.Average(x => x.SINAV1);
                MessageBox.Show(ortalama.ToString(), "Sınav 1 ortlama puanları: ");
            }
            if (radioButton9.Checked == true)
            {
                dataGridView1.DataSource = db.SINAV1GECEN();
            }
            if (radioButton10.Checked == true)
            {
                int max = Convert.ToInt32(db.TBLNOTLAR.Max(x => x.SINAV1));
                short a = ((short)max);
                var isim = from d1 in db.TBLNOTLAR
                           join d2 in db.TBLOGRENCI
                           on d1.OGR equals d2.ID
                           where d1.SINAV1 == a
                           select new
                           {
                               ÖĞRENCİ = d2.AD,
                               Not = d1.SINAV1
                           };
                dataGridView1.DataSource = isim.ToList();
            }
            if (radioButton11.Checked == true)
            {
                var min = db.TBLNOTLAR.Min(x => x.SINAV1);
                MessageBox.Show("1 sınavda en yuksek not " + min.ToString());
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCI
                        on d1.OGR equals d2.ID
                        join d3 in db.TBLDERSLER
                        on d1.DERS equals d3.DERSAD
                        select new
                        {
                            ÖGRENCİ = d2.AD,
                            SOAYAD = d2.SOYAD,
                            DERS = d3.DERSAD,
                            SINAV1 = d1.SINAV1,
                            SINAV2 = d1.SINAV2,
                            SINAV3 = d1.SINAV3,
                            ORTALAMA = d1.ORTALAMA
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
