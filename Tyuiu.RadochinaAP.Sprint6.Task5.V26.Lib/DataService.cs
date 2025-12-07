using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
            public double[] LoadFromDataFile(string path)
        {
            List<double> result = new List<double>();

            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException($"Файл не найден: {path}");
                }

                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string cleanLine = line.Trim();

                    if (string.IsNullOrEmpty(cleanLine))
                        continue;

                    // Пробуем преобразовать в число
                    if (double.TryParse(cleanLine.Replace('.', ','), out double num))
                    {
                        // Округляем до 3 знаков
                        num = Math.Round(num, 3);

                        // Проверяем кратность 5
                        if (Math.Abs(num % 5) < 0.001)
                        {
                            result.Add(num);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении файла: " + ex.Message);
            }

            return result.ToArray();
        }
    }
}