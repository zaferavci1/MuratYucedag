using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int misir, su, bilet, cay,toplam;
            misir = Convert.ToInt32(textMısır.Text);
            su = Convert.ToInt32(textSu.Text);
            bilet = Convert.ToInt32(textBilet.Text);
            cay = Convert.ToInt32(textCay.Text);
            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            labelToplam.Text = toplam.ToString();
            MessageBox.Show("Toplam BOrcunuz: "+labelToplam.Text);



        }
        

    }
}
