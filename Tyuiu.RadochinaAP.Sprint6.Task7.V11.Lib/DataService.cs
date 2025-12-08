using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        
        {
            string[] lines = File.ReadAllLines(path);

            // Убираем пустые строки
            int realRows = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i].Trim()))
                {
                    realRows++;
                }
            }

            // Максимальное количество столбцов
            int maxCols = 0;
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line.Trim()))
                {
                    string[] values = line.Trim().Split(';');
                    if (values.Length > maxCols)
                    {
                        maxCols = values.Length;
                    }
                }
            }

            int rows = realRows;
            int cols = maxCols;

            int[,] matrix = new int[rows, cols];

            int rowIndex = 0;
            for (int i = 0; i < lines.Length && rowIndex < rows; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] values = line.Split(';');
                for (int j = 0; j < cols; j++)
                {
                    if (j < values.Length && !string.IsNullOrWhiteSpace(values[j]))
                    {
                        string val = values[j].Trim();
                        matrix[rowIndex, j] = int.Parse(val);
                    }
                    else
                    {
                        matrix[rowIndex, j] = 0;
                    }
                }
                rowIndex++;
            }

            return matrix;
        }

        public int[,] ReplaceZerosInSecondColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            // 1. В столбце с номером 2 (индекс 2) заменить 0 на 1
            if (cols > 2) // Если есть столбец с индексом 2
            {
                for (int i = 0; i < rows; i++)
                {
                    if (result[i, 2] == 0)
                    {
                        result[i, 2] = 1;
                    }
                }
            }

            // 2. В 5-й строке (индекс 4) все отрицательные заменить на 9
            if (rows >= 5)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (result[4, j] < 0)
                    {
                        result[4, j] = 9;
                    }
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