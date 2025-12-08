using Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestBothOperations()
        {
            DataService ds = new DataService();

            // Матрица из ошибки
            int[,] matrix = new int[10, 10]
            {
                {1,4,18,17,2,13,14,-14,1,-18},
                {-15,18,7,-3,-3,-6,-1,-17,18,-18},
                {10,-15,2,-2,-8,-16,1,3,-2,-13},
                {-4,-7,13,-7,-11,11,7,-20,-10,-16},
                {14,-8,-2,20,5,0,5,1,-6,-17}, // 5-я строка
                {10,12,-1,8,2,3,15,-17,4,-4},
                {8,-19,0,20,1,-9,10,7,2,1},   // 0 в столбце 2
                {-14,-15,6,1,-11,-9,11,13,0,13}, // 0 в столбце 2?
                {-14,16,-6,5,11,-1,-11,-6,5,-7},
                {-17,17,-8,-20,5,12,20,13,-7,15}
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            // Проверяем 5-ю строку: отрицательные → 9
            Assert.AreEqual(9, result[4, 1]);  // -8 → 9
            Assert.AreEqual(9, result[4, 2]);  // -2 → 9
            Assert.AreEqual(9, result[4, 8]);  // -6 → 9
            Assert.AreEqual(9, result[4, 9]);  // -17 → 9

            // Проверяем столбец 2: 0 → 1
            // В строке 6 (индекс 6) в столбце 2 было 0 → должно стать 1
            Assert.AreEqual(1, result[6, 2]);  // 0 → 1

            // В строке 7 (индекс 7) в столбце 2 было 6, не меняется
            Assert.AreEqual(6, result[7, 2]);  // 6 → 6
        }
    }
}