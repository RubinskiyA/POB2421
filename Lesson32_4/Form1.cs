using System.Drawing.Text;

namespace Lesson32_4
{
    public partial class Form1 : Form
    {
        private BottonColor bottonColor;
        public Form1()
        {
            InitializeComponent();
            bottonColor=new BottonColor();
        }

        private void buttonForColor_Click(object sender, EventArgs e)
        {
            buttonForColor.BackColor = bottonColor.GetColor();
            buttonForColor.ForeColor = bottonColor.GetColor();
        }
    }
}