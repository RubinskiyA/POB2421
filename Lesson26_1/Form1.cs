namespace Lesson26_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            if  (checkBox1.Checked&& checkBox2.Checked)
            {
                MessageBox.Show("ֲûבנאם פכאזמך 1 ט 2.");
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                MessageBox.Show("ֲûבנאם פכאזמך 2 ט 3.");
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                MessageBox.Show("ֲûבנאם פכאזמך 1 ט 3.");
            }
            else if(checkBox1.Checked)
            {
                MessageBox.Show("ֲûבנאם פכאזמך 1.");
            }
            else if(checkBox2.Checked)
            {
                MessageBox.Show("ֲûבנאם פכאזמך 2.");
            }
            else if (checkBox3.Checked)
            {
                MessageBox.Show("ֲûבנאם פכאזמך 3.");
            }
            else
            {
                MessageBox.Show("װכאזמך םו גûבנאם");
            }
        }
    }
}
