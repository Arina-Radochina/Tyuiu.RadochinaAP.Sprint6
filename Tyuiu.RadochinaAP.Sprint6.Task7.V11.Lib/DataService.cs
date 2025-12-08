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
                string[] values = line.Split(';');
                if (values.Length > maxCols)
                {
                    maxCols = values.Length;
                }
            }

            int rows = lines.Length;
            int cols = maxCols;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    if (j < values.Length && !string.IsNullOrEmpty(values[j]) && values[j].Trim() != "")
                    {
                        matrix[i, j] = int.Parse(values[j].Trim());
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }

        public int[,] ReplaceZerosInSecondColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (cols < 3) // Проверяем, что есть хотя бы 3 столбца (индекс 2)
            {
                return (int[,])matrix.Clone();
            }

            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                if (result[i, 2] == 0)
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