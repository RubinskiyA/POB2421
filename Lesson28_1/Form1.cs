namespace Lesson28_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            int n = random.Next(1, 6);
            switch (n)
            {
                case 1: labelRandomText.Text = "\"����� - ��� ����������� ���� �� ����� ������� � ������, �� ������� ����������.\" - ������� ��������"; break;
                case 2: labelRandomText.Text = "\"���� ����������, ������� �� ������ ������ � ����.\" - ������� �����"; break;
                case 3: labelRandomText.Text = "\"������ ������ ����������� ������� - ������� ���.\" - ����� ������"; break;
                case 4: labelRandomText.Text = "\"��������� - ��� �����������, ������� � ���������� �������.\" - ������� ��������"; break;
                case 5: labelRandomText.Text = "\"�� �����, ������� ��� �� ������� - �����, ������� ��� �� ������������.\" - ������� �����"; break;
            }
        }

        private void labelRandomText_Click(object sender, EventArgs e)
        {

        }
    }
}
