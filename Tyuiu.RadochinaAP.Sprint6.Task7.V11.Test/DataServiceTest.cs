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

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;2;3;4\n5;0;7;8\n9;10;0;12");

            int[,] matrix = ds.GetMatrix(tempFile);

            Assert.AreEqual(3, matrix.GetLength(0));
            Assert.AreEqual(4, matrix.GetLength(1));
            Assert.AreEqual(0, matrix[1, 1]);

            File.Delete(tempFile);
        }

        [TestMethod]
        public void ValidReplaceZerosInSecondColumn()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 4]
            {
                {1, 2, 0, 4},
                {5, 6, 7, 8},
                {9, 10, 0, 12}
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            Assert.AreEqual(1, result[0, 2]); // 0 → 1
            Assert.AreEqual(7, result[1, 2]); // без изменений
            Assert.AreEqual(1, result[2, 2]); // 0 → 1
        }

        [TestMethod]
        public void GetMatrixWithEmptyCells()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            // Файл с пустыми значениями
            File.WriteAllText(tempFile, "1;2;3;\n;0;;8\n9;;0;12");

            int[,] matrix = ds.GetMatrix(tempFile);

            // Должен корректно обработать пустые значения как 0
            Assert.AreEqual(3, matrix.GetLength(0));
            Assert.AreEqual(4, matrix.GetLength(1));
            Assert.AreEqual(0, matrix[0, 3]); // пустое значение
            Assert.AreEqual(0, matrix[1, 0]); // пустое значение
            Assert.AreEqual(0, matrix[1, 2]); // пустое значение
            Assert.AreEqual(0, matrix[2, 1]); // пустое значение

            File.Delete(tempFile);
        }
    }
}