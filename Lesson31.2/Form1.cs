using Lesson31._1;

namespace Lesson31._2
{
    public partial class Form1 : Form
    {
        private DirectoryInfo dinfo;
       private bool isOpen = false;
        public Form1()
        {
            InitializeComponent();
            dinfo = new DirectoryInfo(Environment.CurrentDirectory);
            UpdateFiles();

        }
        public void UpdateFiles()
        {
            listBoxFiles.Items.Clear();
            foreach (FileInfo file in dinfo.GetFiles())
            {
                if (file.Extension == ".txt")
                {
                    listBoxFiles.Items.Add(file.Name);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxText.Text = ClassFileManager.Reader(dinfo.FullName + "\\" + listBoxFiles.SelectedItem);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                saveFileDialog1.InitialDirectory = dinfo.FullName;
                saveFileDialog1.Filter = "*.txt|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //ClassFileManager.Create(saveFileDialog1.FileName);
                    ClassFileManager.Writer(saveFileDialog1.FileName, textBoxText.Text);
                    UpdateFiles();

                }
            }
            else ClassFileManager.Writer(dinfo.FullName + "\\" + listBoxFiles.SelectedItem, textBoxText.Text);
        }


        private void listBoxFiles_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex != -1)
            {
                textBoxText.Text = ClassFileManager.Reader(dinfo.FullName + "\\" + listBoxFiles.SelectedItem);
                isOpen = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex != -1) 
            { 
            ClassFileManager.Delete(dinfo.FullName + "\\" + listBoxFiles.SelectedItem);
            UpdateFiles();
            textBoxText.Clear(); 
            }

        }
    }
}
