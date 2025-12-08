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
        public void TestReplaceInSecondColumn()
        {
            DataService ds = new DataService();

            // Тестируем именно столбец с индексом 2 (третий столбец)
            int[,] matrix = new int[3, 5]
            {
                {1, 2, 0, 4, 5},     // 0 в столбце 2 → должно стать 1
                {6, 7, 8, 9, 10},    // 8 в столбце 2 → без изменений
                {11, 12, 0, 14, 15}  // 0 в столбце 2 → должно стать 1
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // Проверяем изменения только в столбце с индексом 2
            Assert.AreEqual(1, result[0, 2]);  // 0 → 1
            Assert.AreEqual(8, result[1, 2]);  // без изменений
            Assert.AreEqual(1, result[2, 2]);  // 0 → 1

            // Проверяем, что другие столбцы не изменились
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(4, result[0, 3]);
            Assert.AreEqual(5, result[0, 4]);
        }

        [TestMethod]
        public void TestWithDoubleZero()
        {
            DataService ds = new DataService();

            // Тест с "00" в файле
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;2;00\n4;5;6\n7;8;00");

            try
            {
                int[,] matrix = ds.GetMatrix(tempFile);
                int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

                // "00" должно быть прочитано как 0 и заменено на 1
                Assert.AreEqual(1, result[0, 2]);  // 00 → 0 → 1
                Assert.AreEqual(6, result[1, 2]);  // без изменений
                Assert.AreEqual(1, result[2, 2]);  // 00 → 0 → 1
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void TestSpecificCase()
        {
            DataService ds = new DataService();

            // Тест конкретно для 5-й строки из ошибки
            int[,] matrix = new int[10, 10]
            {
                {1,4,18,17,2,13,14,-14,1,-18},
                {-15,18,7,-3,-3,-6,-1,-17,18,-18},
                {10,-15,2,-2,-8,-16,1,3,-2,-13},
                {-4,-7,13,-7,-11,11,7,-20,-10,-16},
                {14,-8,-2,20,5,0,5,1,-6,-17}, // Здесь в столбце 2 значение -2, не 0!
                {10,12,-1,8,2,3,15,-17,4,-4},
                {8,-19,0,20,1,-9,10,7,2,1},
                {-14,-15,6,1,-11,-9,11,13,0,13},
                {-14,16,-6,5,11,-1,-11,-6,5,-7},
                {-17,17,-8,-20,5,12,20,13,-7,15}
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // Проверяем 5-ю строку (индекс 4)
            // В столбце 2 значение -2, поэтому НЕ должно меняться
            Assert.AreEqual(-2, result[4, 2]); // Не должно стать 9!

            // Проверяем другие строки где есть 0 в столбце 2
            // В 7-й строке (индекс 6) в столбце 2 значение 0 → должно стать 1
            Assert.AreEqual(1, result[6, 2]); // 0 → 1

            // В 8-й строке (индекс 7) в столбце 2 значение 6, не 0
            Assert.AreEqual(6, result[7, 2]);
        }
    }
}