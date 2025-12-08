using Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMatrixDirectly()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();

            try
            {
                // Создаем точно такой же CSV как в тестирующей системе
                string[] csvLines = {
            "1;4;18;17;2;13;14;-14;1;-18",
            "-15;18;7;-3;-3;-6;-1;-17;18;-18",
            "10;-15;2;-2;-8;-16;1;3;-2;-13",
            "-4;-7;13;-7;-11;11;7;-20;-10;-16",
            "14;-8;-2;20;5;0;5;1;-6;-17",
            "10;12;-1;8;2;3;15;-17;4;-4",
            "8;-19;0;20;1;-9;10;7;2;1",
            "-14;-15;6;1;-11;-9;11;13;0;13",
            "-14;16;-6;5;11;-1;-11;-6;5;-7",
            "-17;17;-8;-20;5;12;20;13;-7;15"
        };

                File.WriteAllLines(tempFile, csvLines);

                // Вызываем GetMatrix - это то, что проверяет тестирующая система
                int[,] result = ds.GetMatrix(tempFile);

                // Проверяем 5-ю строку
                Assert.AreEqual(9, result[4, 1]);  // -8 → 9
                Assert.AreEqual(9, result[4, 2]);  // -2 → 9
                Assert.AreEqual(9, result[4, 8]);  // -6 → 9
                Assert.AreEqual(9, result[4, 9]);  // -17 → 9

                Console.WriteLine("5-я строка после GetMatrix:");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(result[4, j] + " ");
                }
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }
    }
}