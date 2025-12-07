using Tyuiu.RadochinaAP.Sprint6.Task4.V23.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task4.V23
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
                // Получаем значения
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                // Получаем массив значений
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;

                // Настраиваем график
                chartFunction.Titles.Clear();
                chartFunction.Titles.Add("График функции 4 - 2x + (2+cos(x))/(2x-2)");

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                // Очищаем предыдущие данные
                textBoxResult.Text = "";
                chartFunction.Series[0].Points.Clear();

                // Выводим результаты
                for (int i = 0; i < len; i++)
                {
                    // Добавляем точку на график
                    chartFunction.Series[0].Points.AddXY(startStep + i, valueArray[i]);

                    // Добавляем в TextBox
                    textBoxResult.AppendText($"x = {startStep + i}: {valueArray[i]}" + Environment.NewLine);
                }

                // Меняем кнопку
                buttonDone.Text = "Выполнено!";
                buttonDone.BackColor = Color.LightGreen;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем путь для сохранения
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";

                // Получаем значения для сохранения
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                // Сохраняем в файл
                ds.SaveToFile(path, valueArray, startStep, stopStep);

                // Сообщение об успехе
                DialogResult dialogResult = MessageBox.Show(
                    $"Файл {path} сохранен успешно!\nОткрыть его в блокноте?",
                    "Сохранение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    // Открываем файл в блокноте
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции:\n" +
                          "F(x) = 4 - 2x + (2+cos(x))/(2x-2)\n" +
                          "Диапазон: от -5 до 5\n" +
                          "Шаг: 1\n" +
                          "При делении на ноль (x=1) возвращается 0\n" +
                          "Результат округлен до 2 знаков\n\n" +
                          "Задание выполнила: Радочина Арина Павловна, ПИНб-25-1\n" +
                          "Вариант 23",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            if (buttonDone.Text != "Выполнено!")
                buttonDone.BackColor = Color.FromArgb(0, 200, 0);
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            if (buttonDone.Text != "Выполнено!")
                buttonDone.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.FromArgb(0, 150, 0);
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.FromArgb(100, 100, 255);
        }

        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.FromArgb(0, 0, 192);
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp.BackColor = Color.FromArgb(173, 216, 230); // LightBlue
        }

        private void buttonHelp_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp.BackColor = Color.FromArgb(135, 206, 235); // SkyBlue
        }
    }
}