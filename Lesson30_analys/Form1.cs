namespace Lesson30_analys
{
    public partial class Analisator : Form
    {
        private Analizer analizer;
        private string result;
        public Analisator()
        {
            InitializeComponent();
            textBoxSubString.Enabled = false;
            radioButtonLower.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                textBoxSubString.Enabled = true;

            }
            else
                textBoxSubString.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            result = "";
            labelOutput.Text = "";
            analizer = new Analizer(textBoxInput.Text);
            if (checkBoxCount.Checked) result += analizer.getLength() + "\n";
            if (checkBoxFind.Checked)
            {
                result += analizer.haveSubSring(textBoxSubString.Text).ToString() + "\n";
            }
            if (radioButtonUpper.Checked) result += analizer.toUpper();
            if (radioButtonLower.Checked) result += analizer.toLower();
            labelOutput.Text = result;
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                checkBoxCount.Checked = true;
                checkBoxFind.Checked = true;
                radioButtonLower.Checked = true;
            }
            else
            {
                checkBoxCount.Checked = false;
                checkBoxFind.Checked = false;
                radioButtonLower.Checked = false;
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}