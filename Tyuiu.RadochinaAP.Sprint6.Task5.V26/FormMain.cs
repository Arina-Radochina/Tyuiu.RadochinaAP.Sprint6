using System.IO;
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
                // Очищаем предыдущие данные
                dataGridViewNums.Rows.Clear();
                chartDiag.Series[0].Points.Clear();

                // Загружаем числа, кратные 5
                double[] nums = ds.LoadFromDataFile(path);

                // Выводим в DataGridView
                for (int i = 0; i < nums.Length; i++)
                {
                    dataGridViewNums.Rows.Add(i.ToString(), nums[i].ToString("F3"));
                    chartDiag.Series[0].Points.AddXY(i, nums[i]);
                }

                // Обновляем информацию
                labelInfo.Text = $"Найдено чисел кратных 5: {nums.Length}";
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
                // Альтернативный способ: находим последний слэш в пути
                int lastSlashIndex = path.LastIndexOf('\\');
                if (lastSlashIndex > 0)
                {
                    string directory = path.Substring(0, lastSlashIndex);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                }

                // Если файла нет - создаем тестовые данные
                if (!File.Exists(path))
                {
                    string[] testData = {
                "-17.0", "-10.0", "12.0", "-14.32", "5.0",
                "-7.84", "12.89", "-1.57", "-3.64", "-13.26",
                "-8.91", "-17.77", "35.0", "-9.0", "13.83",
                "12.76", "8.86", "10.0", "-1.49", "-7.0"
            };
                    File.WriteAllLines(path, testData);
                }

                // Открываем файл
                System.Diagnostics.Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание выполнила: Радочина Арина Павловна, ПИНб-25-1\n" +
                "Вариант 26\n\n" +
                "Задание:\n" +
                "1. Прочитать числа из файла\n" +
                "2. Вывести числа, кратные 5\n" +
                "3. Построить диаграмму\n" +
                "4. Округлить до 3 знаков",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Эффекты для кнопок
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
            buttonHelp.BackColor = Color.FromArgb(173, 216, 230);
        }

        private void buttonHelp_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp.BackColor = Color.FromArgb(135, 206, 235);
        }
    }
}