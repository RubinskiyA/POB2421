namespace Lesson32_2
{
    public partial class Form1 : Form
    {
        private StringClass stringClass;
        public Form1()
        {
            InitializeComponent();
            stringClass = new StringClass();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonPolindrom_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.SetStroka(textBoxText.Text);
            if (stringClass.IsPolindrome()) labelResult.Text = "Строка палиндром";
            else labelResult.Text = "Строка не палиндром";
        }

        private void radioButtonReverse_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.SetStroka(textBoxText.Text);
            labelResult.Text = stringClass.Reverse();
        }

        private void radioButtonUpper_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.SetStroka(textBoxText.Text);
            labelResult.Text = stringClass.toUpper();
        }

        private void radioButtonLower_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.SetStroka(textBoxText.Text);
            labelResult.Text = stringClass.toLower();
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
                stringClass.SetStroka(textBoxText.Text);
            if (textBoxIndex.Text.Length != 0)
            {
                labelResult.Text = stringClass.SubStr(int.Parse(textBoxIndex.Text));
            }
            else labelResult.Text = "";

        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            stringClass.SetStroka(textBoxText.Text);
            if (textBoxFind.Text.Length != 0)
            {
                if (stringClass.Search(textBoxFind.Text)) labelResult.Text = ("Строка содержит слово ") + textBoxFind.Text;
                else labelResult.Text = ("Строка не содержит слово");
            }
            else labelResult.Text = "";
        }
    }
}