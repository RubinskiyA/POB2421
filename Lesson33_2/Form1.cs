using System.Threading.Tasks;

namespace Lesson33_2
{
    public partial class Form1 : Form
    {
        private MyTask[] mas;
        private int count;
        private int selectedIndex;
        public Form1()
        {
            InitializeComponent();
            mas = new MyTask[count];
            count = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask();
        }
        private void AddTask()
        {
            if (textBoxTextTask.Text.Length != 0 && listBoxPriority.SelectedIndex != -1)
            {
                MyTask myTask = new MyTask(textBoxTextTask.Text, dateTimePickerTask.Value, listBoxPriority.SelectedItem!.ToString());
                count++;
                Array.Resize<MyTask>(ref mas, count);
                mas[count - 1] = myTask;
                listBoxTask.Items.Add(myTask.getTask());
                listBoxDate.Items.Add(myTask.getDate());
                listBoxTaskPriority.Items.Add(myTask.getPriority());
                textBoxTextTask.Clear();
                listBoxPriority.SelectedIndex = -1;
                dateTimePickerTask.Value = DateTime.Now;

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveTask();
        }
        private void RemoveTask()
        {
            if (listBoxTask.SelectedIndex != -1)
            {
                int index = listBoxTask.SelectedIndex;
                listBoxTask.Items.RemoveAt(index);
                listBoxDate.Items.RemoveAt(index);
                listBoxTaskPriority.Items.RemoveAt(index);
                MyTask[] tempMas = new MyTask[--count];
                int j = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i != index)
                    {
                        tempMas[j++] = mas[i];
                    }
                }
                Array.Resize<MyTask>(ref mas, count);
                Array.Copy(tempMas, mas, count);

            }
        }

        private void listBoxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTask.SelectedIndex != -1)
            {
                selectedIndex = listBoxTask.SelectedIndex;
                MyTask myTask = mas[selectedIndex];
                textBoxTextTask.Text = myTask.getTask();
                switch (myTask.getPriority())
                {
                    case "Низкий": listBoxPriority.SelectedIndex = 0; break;
                    case "Средний": listBoxPriority.SelectedIndex = 1; break;
                    case "Высокий": listBoxPriority.SelectedIndex = 2; break;
                }
                dateTimePickerTask.Value = myTask.getDate();

            }
        }

        private void buttonRewrite_Click(object sender, EventArgs e)
        {
            mas[selectedIndex].setTask(textBoxTextTask.Text);
            mas[selectedIndex].setPriority(listBoxPriority.SelectedItem!.ToString());
            mas[selectedIndex].setDate(dateTimePickerTask.Value);
            Update();
        }
        private void Update()
        {
            listBoxDate.Items.Clear();
            listBoxTaskPriority.Items.Clear();
            listBoxTask.Items.Clear();
            foreach(MyTask myTask in mas)
            {
                listBoxTask.Items.Add(myTask.getTask());
                listBoxDate.Items.Add(myTask.getDate());
                listBoxTaskPriority.Items.Add(myTask.getPriority()); 
            }

        }
    }
}
