using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> numbers = new List<double>();

            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException($"Файл не найден: {path}");
                }

                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Trim();

                        if (string.IsNullOrEmpty(line))
                            continue;

                        // Пробуем разные форматы чисел
                        if (double.TryParse(line.Replace('.', ','), out double number) ||
                            double.TryParse(line, out number))
                        {
                            numbers.Add(Math.Round(number, 3)); // Округляем до 3 знаков
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении файла: " + ex.Message);
            }

            return numbers.ToArray(); // Возвращаем ВСЕ числа из файла
        }

        public double[] FilterNumbersMultipleOfFive(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return new double[0];

            List<double> filtered = new List<double>();

            foreach (double num in numbers)
            {
                double remainder = Math.Abs(num % 5);
                bool isMultipleOfFive = remainder < 0.001 || Math.Abs(remainder - 5) < 0.001;

                if (isMultipleOfFive)
                {
                    filtered.Add(num);
                }
            }

            return filtered.ToArray();
        }
    }
}
