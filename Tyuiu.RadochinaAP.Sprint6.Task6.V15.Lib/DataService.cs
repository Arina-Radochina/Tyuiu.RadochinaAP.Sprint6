using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task6.V15.Lib
{
    public class DataService : ISprint6Task6V15
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                // Проверяем файл
                if (!File.Exists(path))
                {
                    return "Файл не найден";
                }

                // Читаем все строки
                string[] lines = File.ReadAllLines(path);
                StringBuilder result = new StringBuilder();

                // Обрабатываем каждую строку
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();

                    if (!string.IsNullOrEmpty(line))
                    {
                        // Разделяем на слова
                        string[] words = line.Split(
                            new char[] { ' ', '\t' },
                            StringSplitOptions.RemoveEmptyEntries
                        );

                        if (words.Length > 0)
                        {
                            // Берем последнее слово
                            string lastWord = words[words.Length - 1];

                            // Добавляем к результату
                            if (result.Length > 0)
                            {
                                result.Append(" ");
                            }
                            result.Append(lastWord);
                        }
                    }
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                return "Ошибка: " + ex.Message;
            }
        }
    }
}