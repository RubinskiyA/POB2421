namespace Lesson29._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResult.Text = Total.ToString("C");

        }
        private int Total;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Total += 5000;
            }
            else Total -= 5000;
            labelResult.Text = Total.ToString("C");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Total += 3000;
            }
            else Total -= 3000;
            labelResult.Text = Total.ToString("C");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Total += 15000;
            }
            else Total -= 15000;
            labelResult.Text = Total.ToString("C");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Total += 10000;
            }
            else Total -= 10000;
            labelResult.Text = Total.ToString("C");
        }
    }
}
