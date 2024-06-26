namespace Lesson29._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double price;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    price = 1000;
                    pictureBox1.Image = new Bitmap(Properties.Resources.wood);
                    break;
                case 1:
                    price = 3000;
                    pictureBox1.Image = new Bitmap(Properties.Resources.steel);
                    break;
                case 2:
                    price = 1500;
                    pictureBox1.Image = new Bitmap(Properties.Resources.Plastic);
                    break;
                case 3:
                    price = 900;
                    pictureBox1.Image = new Bitmap(Properties.Resources.paper);
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double m, n;
                double result;
                double.TryParse(textBox1.Text, out m);
                double.TryParse(textBox2.Text, out n);
                label6.Text = $"—тоимость вашего заказа площадью {m*n} м^2 : {price * m * n} рублей";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
