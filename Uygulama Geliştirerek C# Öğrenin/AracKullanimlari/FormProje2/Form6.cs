using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProje2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Bilgileri: " + textBox1.Text+" TC: "+maskedTextBox2.Text+" Telefon No: "+maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
