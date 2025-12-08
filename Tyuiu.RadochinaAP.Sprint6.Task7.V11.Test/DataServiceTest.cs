using Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;2;3\n4;5;6\n7;8;9");

            try
            {
                int[,] matrix = ds.GetMatrix(tempFile);
                Assert.AreEqual(3, matrix.GetLength(0));
                Assert.AreEqual(3, matrix.GetLength(1));
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void TestReplaceNegativeInFifthRow()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[10, 10]
            {
                {1,4,18,17,2,13,14,-14,1,-18},
                {-15,18,7,-3,-3,-6,-1,-17,18,-18},
                {10,-15,2,-2,-8,-16,1,3,-2,-13},
                {-4,-7,13,-7,-11,11,7,-20,-10,-16},
                {14,-8,-2,20,5,0,5,1,-6,-17},
                {10,12,-1,8,2,3,15,-17,4,-4},
                {8,-19,0,20,1,-9,10,7,2,1},
                {-14,-15,6,1,-11,-9,11,13,0,13},
                {-14,16,-6,5,11,-1,-11,-6,5,-7},
                {-17,17,-8,-20,5,12,20,13,-7,15}
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // 5-я строка
            Assert.AreEqual(9, result[4, 1]);
            Assert.AreEqual(9, result[4, 2]);
            Assert.AreEqual(9, result[4, 8]);
            Assert.AreEqual(9, result[4, 9]);
        }

        [TestMethod]
        public void TestNoFifthRow()
        {
            DataService ds = new DataService();

            // Матрица без 5-й строки (только 3 строки)
            int[,] matrix = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // Не должно быть ошибки IndexOutOfRangeException
            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // Проверяем, что матрица не изменилась
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(matrix[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestExactlyFourRows()
        {
            DataService ds = new DataService();

            // Матрица с 4 строками (нет 5-й строки)
            int[,] matrix = new int[4, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
                {10, 11, 12}
            };

            // Не должно быть ошибки
            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(matrix[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestExactlyFiveRows()
        {
            DataService ds = new DataService();

            // Матрица с ровно 5 строками
            int[,] matrix = new int[5, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
                {10, 11, 12},
                {-1, -2, -3} // 5-я строка с отрицательными
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // Проверяем, что 5-я строка обработана
            Assert.AreEqual(9, result[4, 0]); // -1 → 9
            Assert.AreEqual(9, result[4, 1]); // -2 → 9
            Assert.AreEqual(9, result[4, 2]); // -3 → 9

            // Остальные строки не изменились
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(4, result[1, 0]);
        }

        [TestMethod]
        public void TestSaveMatrix()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();

            try
            {
                int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
                ds.SaveMatrixToCsv(matrix, tempFile);

                Assert.IsTrue(File.Exists(tempFile));
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }
    }
}