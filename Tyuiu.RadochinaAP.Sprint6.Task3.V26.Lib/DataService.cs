using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task3.V26.Lib
{
    public class DataService : ISprint6Task3V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] resultMatrix = (int[,])matrix.Clone();

            int thirdRow = 2;

            for (int j = 0; j < columns; j++)
            {
                if (resultMatrix[thirdRow, j] % 2 == 0)
                {
                    resultMatrix[thirdRow, j] = 0;
                }
            }

            return resultMatrix;
        }

        public int[,] GetTestMatrix()
        {
            return new int[5, 5]
            {
                { 16, 19, 17, 2, 8 },
                { -17, 8, -17, -8, 1 },
                { -7, 17, -2, 1, -3 },
                { -12, 0, -17, 15, 6 },
                { 17, -6, -17, 18, -19 }
            };
        }
    }
}