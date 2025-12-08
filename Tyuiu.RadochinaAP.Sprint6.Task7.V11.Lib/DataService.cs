using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        
        {
            string[] lines = File.ReadAllLines(path);

            // Находим максимальное количество столбцов
            int maxCols = 0;
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(';');
                    if (values.Length > maxCols)
                    {
                        maxCols = values.Length;
                    }
                }
            }

            int rows = lines.Length;
            int cols = maxCols;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    // Пустая строка - все значения 0
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
                else
                {
                    string[] values = lines[i].Split(';');
                    for (int j = 0; j < cols; j++)
                    {
                        if (j < values.Length && !string.IsNullOrWhiteSpace(values[j]))
                        {
                            string val = values[j].Trim();
                            if (val == "00") // Обработка "00" как 0
                            {
                                matrix[i, j] = 0;
                            }
                            else
                            {
                                matrix[i, j] = int.Parse(val);
                            }
                        }
                        else
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }

            return matrix;
        }

        public int[,] ReplaceZerosInSecondColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            // ВАЖНО: столбец с номером 2 - это третий столбец (индекс 2)
            for (int i = 0; i < rows; i++)
            {
                if (cols > 2 && result[i, 2] == 0) // Проверяем столбец с индексом 2
                {
                    result[i, 2] = 1;
                }
            }

            return result;
        }

        public void SaveMatrixToCsv(int[,] matrix, string path)
        {
            StringBuilder sb = new StringBuilder();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(matrix[i, j]);
                    if (j < cols - 1) sb.Append(';');
                }
                if (i < rows - 1) sb.AppendLine();
            }

            File.WriteAllText(path, sb.ToString(), Encoding.Default);
        }
    }
}