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
                case 1: labelRandomText.Text = "\"Успех - это способность идти от одной неудачи к другой, не потеряв энтузиазма.\" - Уинстон Черчилль"; break;
                case 2: labelRandomText.Text = "\"Будь изменением, которое ты хочешь видеть в мире.\" - Махатма Ганди"; break;
                case 3: labelRandomText.Text = "\"Лучший способ предсказать будущее - создать его.\" - Питер Друкер"; break;
                case 4: labelRandomText.Text = "\"Сложности - это возможности, скрытые в обманчивой обертке.\" - Альберт Эйнштейн"; break;
                case 5: labelRandomText.Text = "\"Не важно, сколько раз вы падаете - важно, сколько раз вы поднимаетесь.\" - Мэрилин Монро"; break;
            }
        }

        private void labelRandomText_Click(object sender, EventArgs e)
        {

        }
    }
}
