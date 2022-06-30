namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                progressBar1.Value = i;
            }
            progressBar1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -=10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (progressBar1.Value==100)
            {
                pictureBox1.Visible = true;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            progressBar1.Value+=25;
            MessageBox.Show("Un Eklendi");
            progressBar1.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            progressBar1.Value += 25;
            MessageBox.Show("Şeker Eklendi");
            progressBar1.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 25;
            MessageBox.Show("Kabartma Tozu Eklendi");
            progressBar1.Visible = true;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 25;
            MessageBox.Show("Tuz Eklendi");
            progressBar1.Visible = true;
            button5.Visible = false;
        }
    }
}