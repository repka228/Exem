using System.Drawing.Text;

namespace Exem
{
    public partial class Form1 : Form
    {
        List<INterfaceTask3> list_task4 = [];
        public Form1()
        {
            InitializeComponent();
            Random rnd = new();
            int count_arr = rnd.Next(5,11);
            int count_list = rnd.Next(5, 11);
            for (int i = 0; i < count_arr; i++) { 
                 list_task4.Add(new Task1_class(rnd.Next(10,21)));
            }
            for (int i = 0; i < count_list; i++)
            {
                list_task4.Add(new TaskList(rnd.Next(10,21)));
            }
            for (int i = 0; i < list_task4?.Count; ++i)
            {
                listBoxTask4.Items.Add(list_task4[i].Name);
            }
        }

        private Task1_class? task1;
        private void ButtonTask1_1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxArraySize.Text, out int size))
            {
                task1 = new (size);
                textBoxTask1_1.Text = task1.Task1();
            }
            else
                MessageBox.Show("Неправильный ввод размера");
        }
        private void ButtonTask1_2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTarget.Text, out int target) && int.TryParse(textBoxArraySize.Text, out int size))
            {
                task1 = new (size);
                textBoxTask1_2.Text = task1.Task1(target);
            }
            else
                MessageBox.Show("Неправильный ввод значения");
        }
    }
}