using Tyuiu.RadochinaAP.Sprint6.Task0.V3.Lib;

namespace Tyuiu.RadochinaAP.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBoxVarX.Text);
                DataService ds = new DataService();
                double result = ds.Calculate(x);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Деление на ноль! x не может быть 1", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила: Радочина Арина Павловна, ПИНб-25-1\n" +
                          "Вариант 3\n" +
                          "Вычислить y(x) = (4x?)/(x?-1) при x = 3",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем цифры, Backspace и минус
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
                e.Handled = true;

            // Минус только в начале
            if (e.KeyChar == '-' && textBoxVarX.Text.Length > 0)
                e.Handled = true;
        }
    }
}