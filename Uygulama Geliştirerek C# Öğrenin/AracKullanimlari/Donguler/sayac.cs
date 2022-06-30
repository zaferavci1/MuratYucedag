namespace Donguler
{
    public partial class sayac : Form
    {
        public sayac()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label3.Text =saniye.ToString();

            if (saniye==60)
            {
                saniye = 0;
                dakika++;
                label2.Text = dakika.ToString()+ ":";

                if (dakika == 5)
                {
                    saat++;
                    label1.Text=saat.ToString()+":" ;
                    dakika = 0;
                }
            }
        }
    }
}