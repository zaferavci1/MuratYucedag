using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EntityOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        DbSınavogrenciEntities db = new DbSınavogrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //var values = db.TBLNOTLAR.Where(x => x.SINAV1 < 50);
                //dataGridView1.DataSource = values.ToList();
                var val = from item in db.TBLOGRENCI
                          join item2 in db.TBLNOTLAR
                          on item.ID equals item2.OGR
                          select new
                          {
                              ORENCI = item.AD,
                              SinavNot1 = item2.SINAV1
                          };
                dataGridView1.DataSource = val.Where(x => x.SinavNot1 < 50).ToList();
                button1.BackColor = Color.YellowGreen;
            }
            if (radioButton2.Checked == true)
            {
                var values = db.TBLOGRENCI.Where(x => x.AD.Equals("Serkan"));
                dataGridView1.DataSource = values.ToList();
                button1.BackColor = Color.YellowGreen;
            }
            if (radioButton3.Checked == true)
            {
                var values = db.TBLOGRENCI.Where(x => x.AD.Equals(textBox1.Text) || x.SOYAD.Equals(textBox1.Text));
                dataGridView1.DataSource = values.ToList();
                button1.BackColor = Color.YellowGreen;
            }
            if (radioButton4.Checked == true)
            {
                var deger = db.TBLOGRENCI.Select(x => new { SOYADI = x.SOYAD });
                var values = from item in db.TBLOGRENCI
                             select new
                             {
                                 SOYAD = item.SOYAD
                             };
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton5.Checked == true)
            {
                var value = db.TBLNOTLAR.Select(x =>
                      new
                      {
                          OgrenciAd = x.OGR,
                          OgrenciOrtalama = x.ORTALAMA,
                          Durum = x.DURUM == true ? "Geçti" : "Kaldı"

                      });
                dataGridView1.DataSource = value.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var values = db.TBLOGRENCI.Select(x => new { Ad = x.AD.ToUpper(), Soyad = x.SOYAD.ToLower() });
                dataGridView1.DataSource = values.ToList();
                //anonymous type
            }
            if (radioButton7.Checked == true)
            {
                var values = db.TBLNOTLAR.SelectMany(x => db.TBLOGRENCI.Where(y => y.ID == x.OGR), (x, y) => new
                {
                    y.AD,
                    x.ORTALAMA,
                    Durum = (x.ORTALAMA >= 50 ? "Geçti" : "Kaldı")
                });
                dataGridView1.DataSource = values.ToList();
                //new yazmaz isek sql de olduğu gibi birbiri ile eşleşen değerlei getirecek
            }
            if (radioButton8.Checked== true)
            {
                var values = db.TBLOGRENCI.OrderBy(x => x.ID).Take(3);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton9.Checked == true)
            {
                var values = db.TBLOGRENCI.OrderByDescending(x => x.ID).Take(3);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton10.Checked == true)
            {
                var values = db.TBLOGRENCI.OrderBy(x => x.AD);
                dataGridView1.DataSource = values.ToList();
            }
            if (radioButton11.Checked==true)
            {
                var values = db.TBLOGRENCI.OrderBy(x => x.ID).Skip(5);
                dataGridView1.DataSource = values.ToList();
            }

        }
    }
        
}
