using System.Drawing.Text;
using System.Threading.Tasks;

namespace Exem
{
    public partial class Form1 : Form
    {
        List<INterfaceTask3> list_task4 = [];
        private event Func<string>? task1_1_method;
        private event Func<int, string>? task1_2_method;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new();
            int count_arr = rnd.Next(5, 11);
            int count_list = rnd.Next(5, 11);
            for (int i = 0; i < count_arr; i++)
            {
                list_task4.Add(new Task1_class(rnd.Next(10, 21)));
            }
            for (int i = 0; i < count_list; i++)
            {
                list_task4.Add(new TaskList(rnd.Next(10, 21)));
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
                task1 = new(size);
                textBoxTask1_1.Text = task1.Task1();
            }
            else
                MessageBox.Show("Неправильный ввод размера");
        }
        private void ButtonTask1_2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTarget.Text, out int target) && int.TryParse(textBoxArraySize.Text, out int size))
            {
                task1 = new(size);
                textBoxTask1_2.Text = task1.Task1(target);
            }
            else
                MessageBox.Show("Неправильный ввод значения");
        }

        private void buttonMethod1_Click(object sender, EventArgs e)
        {
            if (listBoxTask4.SelectedIndex >= 0)
                task1_1_method += list_task4[listBoxTask4.SelectedIndex].Task1;
        }

        private void buttonMethod2_Click(object sender, EventArgs e)
        {
            if (listBoxTask4.SelectedIndex >= 0 && int.TryParse(textBoxTarget.Text, out int target))
                task1_2_method += list_task4[listBoxTask4.SelectedIndex].Task1;
        }

        private void buttonInvokeMethod1_Click(object sender, EventArgs e)
        {
            textBoxTask1_1.Clear();
            textBoxTask1_1.Text = task1_1_method?.Invoke();
        }
        private void buttonInvokeMethod2_Click(object sender, EventArgs e)
        {
            textBoxTask1_2.Clear();
            if (int.TryParse(textBoxTarget.Text, out int target))
                textBoxTask1_2.Text = task1_2_method?.Invoke(target);
        }
        private void buttonMethod1_1Del_Click(object sender, EventArgs e)
        {
            if (listBoxTask4.SelectedIndex >= 0)
            {
                var selectedTask = list_task4[listBoxTask4.SelectedIndex];
                if (task1_1_method != null)
                {
                    task1_1_method -= selectedTask.Task1;
                }
            }
        }

        private void buttonMethod1_2Del_Click(object sender, EventArgs e)
        {
            if (listBoxTask4.SelectedIndex >= 0 && int.TryParse(textBoxTarget.Text, out int target))
            {
                var selectedTask = list_task4[listBoxTask4.SelectedIndex];
                if (task1_2_method != null)
                {
                    task1_2_method -= selectedTask.Task1;
                }
            }
        }
    }
}