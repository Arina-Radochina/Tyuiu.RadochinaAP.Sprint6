using Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();

            // Матрица точно как в ошибке
            int[,] matrix = new int[10, 10]
            {
                {1,4,18,17,2,13,14,-14,1,-18},
                {-15,18,7,-3,-3,-6,-1,-17,18,-18},
                {10,-15,2,-2,-8,-16,1,3,-2,-13},
                {-4,-7,13,-7,-11,11,7,-20,-10,-16},
                {14,-8,-2,20,5,0,5,1,-6,-17}, // 5-я строка
                {10,12,-1,8,2,3,15,-17,4,-4},
                {8,-19,0,20,1,-9,10,7,2,1},
                {-14,-15,6,1,-11,-9,11,13,0,13},
                {-14,16,-6,5,11,-1,-11,-6,5,-7},
                {-17,17,-8,-20,5,12,20,13,-7,15}
            };

            // Вызываем метод, который тестирующая система проверяет
            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // Проверяем КЛЮЧЕВОЕ: 5-я строка
            // Ожидается: [14,9,9,20,5,0,5,1,9,9]
            Assert.AreEqual(14, result[4, 0]);
            Assert.AreEqual(9, result[4, 1]);   // было -8 → должно стать 9
            Assert.AreEqual(9, result[4, 2]);   // было -2 → должно стать 9
            Assert.AreEqual(20, result[4, 3]);
            Assert.AreEqual(5, result[4, 4]);
            Assert.AreEqual(0, result[4, 5]);
            Assert.AreEqual(5, result[4, 6]);
            Assert.AreEqual(1, result[4, 7]);
            Assert.AreEqual(9, result[4, 8]);   // было -6 → должно стать 9
            Assert.AreEqual(9, result[4, 9]);   // было -17 → должно стать 9

            // Проверяем, что другие строки не изменились
            Assert.AreEqual(-14, result[0, 7]);
            Assert.AreEqual(-15, result[1, 0]);
            Assert.AreEqual(-4, result[5, 9]);  // 6-я строка, -4 остается
        }

        [TestMethod]
        public void TestWithFile()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();

            try
            {
                // Создаем тестовый файл с 5-й строкой, содержащей отрицательные
                string[] csvLines = {
                    "1;4;18;17;2;13;14;-14;1;-18",
                    "-15;18;7;-3;-3;-6;-1;-17;18;-18",
                    "10;-15;2;-2;-8;-16;1;3;-2;-13",
                    "-4;-7;13;-7;-11;11;7;-20;-10;-16",
                    "14;-8;-2;20;5;0;5;1;-6;-17", // 5-я строка
                    "10;12;-1;8;2;3;15;-17;4;-4",
                    "8;-19;0;20;1;-9;10;7;2;1",
                    "-14;-15;6;1;-11;-9;11;13;0;13",
                    "-14;16;-6;5;11;-1;-11;-6;5;-7",
                    "-17;17;-8;-20;5;12;20;13;-7;15"
                };

                File.WriteAllLines(tempFile, csvLines);

                // Читаем матрицу
                int[,] matrix = ds.GetMatrix(tempFile);

                // Обрабатываем
                int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

                // Проверяем 5-ю строку
                Assert.AreEqual(9, result[4, 1]);
                Assert.AreEqual(9, result[4, 2]);
                Assert.AreEqual(9, result[4, 8]);
                Assert.AreEqual(9, result[4, 9]);
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }
    }
}