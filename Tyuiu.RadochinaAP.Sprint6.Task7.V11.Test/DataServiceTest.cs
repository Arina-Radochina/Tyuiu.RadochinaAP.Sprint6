using Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Создаем тестовый CSV файл
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;2;3\n4;5;6\n7;8;9");

            try
            {
                int[,] matrix = ds.GetMatrix(tempFile);
                Assert.AreEqual(3, matrix.GetLength(0));
                Assert.AreEqual(3, matrix.GetLength(1));
                Assert.AreEqual(3, matrix[0, 2]);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void Test2()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[2, 3]
            {
                {1, 2, 0},
                {4, 5, 6}
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // Проверяем замену 0 на 1 во 2-м столбце (индекс 2)
            Assert.AreEqual(1, result[0, 2]);
            Assert.AreEqual(6, result[1, 2]);
        }

        [TestMethod]
        public void Test3()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 4]
            {
                {10, 20, 0, 40},
                {50, 60, 70, 80},
                {90, 100, 0, 120}
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            Assert.AreEqual(1, result[0, 2]);  // 0 → 1
            Assert.AreEqual(70, result[1, 2]); // без изменений
            Assert.AreEqual(1, result[2, 2]);  // 0 → 1
        }

        [TestMethod]
        public void Test4()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;2;0;4\n5;6;7;8\n9;10;0;12");

            try
            {
                int[,] matrix = ds.GetMatrix(tempFile);
                int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

                Assert.AreEqual(1, result[0, 2]);  // 0 → 1
                Assert.AreEqual(7, result[1, 2]);  // без изменений
                Assert.AreEqual(1, result[2, 2]);  // 0 → 1
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void Test5()
        {
            DataService ds = new DataService();

            // Тест с разным количеством столбцов
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;2;3\n4;5\n6;7;8;9");

            try
            {
                int[,] matrix = ds.GetMatrix(tempFile);
                int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

                Assert.AreEqual(3, matrix.GetLength(0));
                Assert.AreEqual(4, matrix.GetLength(1)); // максимально 4 столбца
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void Test6()
        {
            DataService ds = new DataService();

            // Тест с пустыми значениями
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;;3\n;5;6\n7;8;");

            try
            {
                int[,] matrix = ds.GetMatrix(tempFile);
                Assert.AreEqual(3, matrix.GetLength(0));
                Assert.AreEqual(3, matrix.GetLength(1));

                // Пустые значения должны быть 0
                Assert.AreEqual(0, matrix[0, 1]);
                Assert.AreEqual(0, matrix[1, 0]);
                Assert.AreEqual(0, matrix[2, 2]);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void Test7()
        {
            DataService ds = new DataService();

            // Тест сохранения файла
            string tempFile = Path.GetTempFileName();
            string saveFile = Path.GetTempFileName();

            try
            {
                int[,] matrix = new int[2, 3]
                {
                    {1, 2, 3},
                    {4, 5, 6}
                };

                ds.SaveMatrixToCsv(matrix, saveFile);
                Assert.IsTrue(File.Exists(saveFile));

                // Проверяем содержимое
                string content = File.ReadAllText(saveFile);
                Assert.IsTrue(content.Contains("1;2;3"));
                Assert.IsTrue(content.Contains("4;5;6"));
            }
            finally
            {
                if (File.Exists(tempFile)) File.Delete(tempFile);
                if (File.Exists(saveFile)) File.Delete(saveFile);
            }
        }
    }
}