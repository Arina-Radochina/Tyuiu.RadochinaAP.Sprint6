using System.IO;
using Tyuiu.RadochinaAP.Sprint6.Task6.V15.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string openFilePath;

        public FormMain()
        {
            InitializeComponent();

            buttonDone.Enabled = false;
            groupBoxInput.Text = "Ввод данных";
            groupBoxResult.Text = "Вывод данных";
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Устанавливаем начальную директорию
                if (Directory.Exists(@"C:\DataSprint6"))
                {
                    openFileDialogTask.InitialDirectory = @"C:\DataSprint6";
                }
                else
                {
                    openFileDialogTask.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }

                openFileDialogTask.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialogTask.FileName = "InPutFileTask6V15.txt";

                if (openFileDialogTask.ShowDialog() == DialogResult.OK)
                {
                    openFilePath = openFileDialogTask.FileName;

                    // Показываем содержимое файла
                    textBoxInput.Text = File.ReadAllText(openFilePath);

                    // Обновляем заголовок
                    groupBoxInput.Text = "Ввод: " + Path.GetFileName(openFilePath);

                    // Активируем кнопку выполнения
                    buttonDone.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(openFilePath))
                {
                    MessageBox.Show("Сначала откройте файл!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Выполняем задание
                string result = ds.CollectTextFromFile(openFilePath);

                // Выводим результат
                textBoxResult.Text = result;

                // Обновляем заголовок
                groupBoxResult.Text = "Вывод: результат обработки";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила: Радочина Арина Павловна\n" +
                          "Группа: ПИНб-25-1\n" +
                          "Вариант: 15\n\n" +
                          "Задание:\n" +
                          "Дан файл InPutFileTask6V15.txt. Загрузить файл через openFileDialog.\n" +
                          "Вывести последнее слово каждой строки в результирующую строку.",
                          "Справка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
    }
}