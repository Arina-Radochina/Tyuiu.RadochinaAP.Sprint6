using Tyuiu.RadochinaAP.Sprint6.Task2.V3.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищаем данные
                dataGridViewFunction.Rows.Clear();
                chartFunction.Series[0].Points.Clear();

                // Получаем значения
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                int len = stopStep - startStep + 1;
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                // Настраиваем заголовки
                chartFunction.Titles.Clear();
                chartFunction.Titles.Add("График функции sin(x)/(x+1.2) + cos(x)*7x - 2");

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                // Заполняем DataGridView и Chart
                for (int i = 0; i < len; i++)
                {
                    // Добавляем строку в DataGridView
                    dataGridViewFunction.Rows.Add(
                        Convert.ToString(startStep + i),
                        Convert.ToString(valueArray[i])
                    );

                    // Добавляем точку на график
                    chartFunction.Series[0].Points.AddXY(startStep + i, valueArray[i]);
                }

                // Меняем текст кнопки
                buttonDone.Text = "Выполнено!";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 200, 0); // Более светлый зеленый
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 192, 0); // Стандартный зеленый
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 150, 0); // Темный зеленый
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции:\r\n" +
                          "F(x) = sin(x)/(x+1.2) + cos(x)*7x - 2\r\n" +
                          "X вводится в радианах\r\n" +
                          "Диапазон: от -5 до 5\r\n" +
                          "Шаг: 1\r\n" +
                          "При делении на ноль возвращается 0\r\n" +
                          "Результат округлен до 2 знаков\r\n" +
                          "\r\nЗадание выполнила: Радочина Арина Павловна, ПИНб-25-1\r\n" +
                          "Вариант 3",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {
            // Обработчик клика по графику (можно оставить пустым)
        }
    }
}