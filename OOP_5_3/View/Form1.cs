using OOP_5_3.Model;

namespace OOP_5_3.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Move();
            person.Eat();
            Human human = new Human("Vasilii");
            human.Name = "Boris";
            MessageBox.Show(human.Name);
        }
    }
}