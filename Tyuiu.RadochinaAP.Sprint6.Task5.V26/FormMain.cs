using Tyuiu.RadochinaAP.Sprint6.Task5.V26.Lib;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
namespace Tyuiu.RadochinaAP.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        string path = @"C:\Users\Кошка\source\repos\Tyuiu.RadochinaAP.Sprint6\Tyuiu.RadochinaAP.Sprint6.Task5.V26\bin\Debug\InPutFileTask5V26.txt";

        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                // Настраиваем DataGridView
                dataGridViewNums.ColumnCount = 2;
                dataGridViewNums.Columns[0].Width = 50;
                dataGridViewNums.Columns[1].Width = 100;
                dataGridViewNums.Columns[0].HeaderText = "Индекс";
                dataGridViewNums.Columns[1].HeaderText = "Значение";

                // Настраиваем график
                chartDiag.Titles.Clear();
                chartDiag.Titles.Add("Диаграмма чисел кратных 5");
                chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
                chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";

                // Очищаем предыдущие данные
                dataGridViewNums.Rows.Clear();
                chartDiag.Series[0].Points.Clear();

                // Загружаем данные из файла
                double[] numsMass = ds.LoadFromDataFile(path);

                // Фильтруем числа кратные 5
                double[] filteredNums = ds.FilterNumbersMultipleOfFive(numsMass);

                // Выводим в DataGridView и на график
                for (int i = 0; i < filteredNums.Length; i++)
                {
                    // Добавляем строку в DataGridView
                    dataGridViewNums.Rows.Add(
                        Convert.ToString(i),
                        Convert.ToString(filteredNums[i])
                    );

                    // Добавляем точку на диаграмму
                    chartDiag.Series[0].Points.AddXY(i, filteredNums[i]);
                }

                // Обновляем информацию
                labelInfo.Text = $"Найдено чисел кратных 5: {filteredNums.Length}";

                // Меняем кнопку
                buttonDone.Text = "Выполнено!";
                buttonDone.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем существует ли файл
                if (!File.Exists(path))
                {
                    // Создаем тестовый файл если его нет
                    string testData = @"15.123
-20.456
7.891
25.000
30.555
12.345
-5.678
40.789
3.141
50.000
17.321
60.999
8.765
-35.432
100.001";

                    File.WriteAllText(path, testData);
                }

                // Открываем файл в блокноте
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание: Прочитать данные из файла InPutFileTask5V26.txt.\n" +
                          "Вывести в dataGridView все числа кратные 5.\n" +
                          "Построить диаграмму по этим значениям.\n" +
                          "Вещественные значения округлить до трех знаков после запятой.\n\n" +
                          "Задание выполнила: Радочина Арина Павловна, ПИНб-25-1\n" +
                          "Вариант 26",
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

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile.BackColor = Color.FromArgb(100, 100, 255);
        }

        private void buttonOpenFile_MouseLeave(object sender, EventArgs e)
        {
            buttonOpenFile.BackColor = Color.FromArgb(0, 0, 192);
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
