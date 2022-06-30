namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            lblSoruNo.Text = soruno.ToString();
            btnSonraki.Enabled=false;

            if(soruno==1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnSonraki.Enabled = false;

                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edildilmiştir?";
                btnA.Text = "1986";
                btnB.Text = "1920";
                btnC.Text = "1923";
                btnD.Text = "1926";
                label4.Text = "1923";
            }
            if (soruno==2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnSonraki.Enabled = false;

                richTextBox1.Text = "Hangi şehir ege bölgemizdedir?";
                btnA.Text = "izmir";
                btnB.Text = "Balikesir";
                btnC.Text = "Hatay";        
                btnD.Text = "İstanbul";
                label4.Text = "izmir";
            }
            if (soruno==3)
            {
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnSonraki.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                richTextBox1.Text = "Son Kuşlar hangi yazara aittir? ";
                btnA.Text = "Sait faik Absaıyanik";
                btnB.Text = "Cemal süreyya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri Güntekin";
                label4.Text = "Sait faik Absaıyanik";
            }
            if (soruno==4)
            {
                btnA.Enabled = false;
                btnB.Enabled= false;
                btnC.Enabled= false;    
                btnD.Enabled= false;
                btnSonraki.Enabled= false;
                pictureBox1.Visible=false;
                pictureBox2.Visible=false;
                MessageBox.Show("Dogru: " + dogru + "\n" + " Yanlis: " + yanlis);
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}