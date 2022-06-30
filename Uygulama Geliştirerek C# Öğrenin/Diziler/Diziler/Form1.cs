using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kişiler = { "Serkan", "Osman", "Ali", "Mehmet", "Zafer","Hilmi","İsa","Atakan" };
            //for (int i = 0; i < kişiler.Length; i++)
            //{
            //    listBox1.Items.Add(kişiler[i]);
            //}

            //int[] sayilar = { 2, 6, 5, 9, 8, 76, 31, 56, 25, };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] >= 10 && sayilar[i] % 2 == 0)
            //    {
            //        listBox1.Items.Add(sayilar[i]);
            //    }
            //}

            //char[] harfler = { 'a', 'b', 'c' }; 
            //label1.Text = harfler[0].ToString();

            string[] kisiler = { "Zafer", "Hilmi", "Serkan", "Osman", "İsa", "Atakan" };
            foreach (string kisi1 in kisiler)
            {
                int a = 0;
                a = kisiler.Length;
                listBox1.Items.Add(kisi1);
                label1.Text= a.ToString();
            }
        }
    }
}
