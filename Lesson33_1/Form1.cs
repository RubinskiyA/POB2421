namespace Lesson33_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxDist.SelectedIndex = 0;
            comboBoxPres.SelectedIndex = 0;
            comboBoxTemp.SelectedIndex = 0;
        }
        private void comboBoxDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistChange();

        }
        private void textBoxDist_TextChanged(object sender, EventArgs e)
        {
            DistChange();
        }
        private void DistChange()
        {
            if (textBoxDist.Text.Length != 0)
            {
                double result = 0;
                Distance distance = new Distance(double.Parse(textBoxDist.Text));
                switch (comboBoxDist.SelectedIndex)
                {
                    case 0:
                        {
                            result = distance.ToSm();
                            labelDistance.Text = textBoxDist.Text + " mm=" + result.ToString() + " cm";
                        }
                        break;
                    case 1:
                        {
                            result = distance.ToDecim();
                            labelDistance.Text = textBoxDist.Text + " mm=" + result.ToString() + " dm";
                        }
                        break;
                    case 2:
                        {
                            result = distance.ToMetr();
                            labelDistance.Text = textBoxDist.Text + " mm=" + result.ToString() + " m";
                        }
                        break;
                    case 3:
                        {
                            result = distance.ToKilometr();
                            labelDistance.Text = textBoxDist.Text + " mm=" + result.ToString() + " km";
                        }
                        break;
                }
            }
            else labelDistance.Text = "";

        }
        private void TempChange()
        {
            if (textBoxTemp.Text.Length != 0)
            {
                double result = 0;
                Temperature temperature = new Temperature(double.Parse(textBoxTemp.Text));
                switch (comboBoxTemp.SelectedIndex)
                {
                    case 0:
                        {
                            result = temperature.TempK();
                            labelTemper.Text = textBoxTemp.Text + " C=" + result.ToString() + " K";
                        }
                        break;
                    case 1:
                        {
                            result = temperature.TempF();
                            labelTemper.Text = textBoxTemp.Text + " C=" + result.ToString() + " F";
                        }
                        break;

                }
            }
            else labelTemper.Text = "";

        }

        private void textBoxTemp_TextChanged(object sender, EventArgs e)
        {
            TempChange();
        }

        private void comboBoxTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            TempChange();
        }

        private void textBoxTemp_TextChanged_1(object sender, EventArgs e)
        {
            TempChange();
        }

        private void comboBoxTemp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TempChange();
        }
    }
}
