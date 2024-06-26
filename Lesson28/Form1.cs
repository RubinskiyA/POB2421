namespace Lesson28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                double.TryParse(textBoxFirstVar.Text, out a);
                double.TryParse(textBoxSecondVar.Text, out b);
                labelResult.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                double.TryParse(textBoxFirstVar.Text, out a);
                double.TryParse(textBoxSecondVar.Text, out b);
                labelResult.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                double.TryParse(textBoxFirstVar.Text, out a);
                double.TryParse(textBoxSecondVar.Text, out b);
                labelResult.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                double.TryParse(textBoxFirstVar.Text, out a);
                double.TryParse(textBoxSecondVar.Text, out b);
                if (b != 0) labelResult.Text = (a / b).ToString();
                else throw new DivideByZeroException("Делить на ноль нельзя!");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxFirstVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxFirstVar.Text.IndexOf(',') != -1 ||
                    textBoxFirstVar.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) textBoxSecondVar.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textBoxSecondVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxSecondVar.Text.IndexOf(',') != -1 ||
                    textBoxSecondVar.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) buttonAdd.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textBoxFirstVar_Enter(object sender, EventArgs e)
        {

        }
    }
}
