using System.Drawing.Text;

namespace Exem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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