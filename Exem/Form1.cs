using System.Drawing.Text;

namespace Exem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private readonly Task1_class task1 = new();
        private void ButtonTask1_1_Click(object sender, EventArgs e)
        {
            textBoxTask1_1.Text = task1.Task1_1((int)numericUpDownArraySize.Value);
        }
        private void ButtonTask1_2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTarget.Text, out int target))
                textBoxTask1_2.Text = task1.Task1_2((int)numericUpDownArraySize.Value, target);
            else
                MessageBox.Show("Неправильный ввод значения");
        }
    }
}