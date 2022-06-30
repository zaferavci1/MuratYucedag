using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dunya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Zafer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Boran";
            label7.Text = "Avci";
            label8.Text = "Kamyoncu";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Bilgisyara Mühendisliği";
            label10.Text = textBox1.Text;
        }
    }
}
