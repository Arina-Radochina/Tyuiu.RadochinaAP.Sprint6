using Tyuiu.RadochinaAP.Sprint6.Task3.V26.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = ds.GetTestMatrix();

            int[,] result = ds.Calculate(matrix);

            Assert.AreEqual(-7, result[2, 0]);   
            Assert.AreEqual(17, result[2, 1]);   
            Assert.AreEqual(0, result[2, 2]);    
            Assert.AreEqual(1, result[2, 3]);    
            Assert.AreEqual(-3, result[2, 4]);  

            Assert.AreEqual(16, result[0, 0]);
            Assert.AreEqual(19, result[0, 1]);
            Assert.AreEqual(17, result[0, 2]);
            Assert.AreEqual(2, result[0, 3]);
            Assert.AreEqual(8, result[0, 4]);

            Assert.AreEqual(-17, result[1, 0]);
            Assert.AreEqual(8, result[1, 1]);
            Assert.AreEqual(-17, result[1, 2]);
            Assert.AreEqual(-8, result[1, 3]);
            Assert.AreEqual(1, result[1, 4]);

            Assert.AreEqual(-12, result[3, 0]);
            Assert.AreEqual(0, result[3, 1]);
            Assert.AreEqual(-17, result[3, 2]);
            Assert.AreEqual(15, result[3, 3]);
            Assert.AreEqual(6, result[3, 4]);

            Assert.AreEqual(17, result[4, 0]);
            Assert.AreEqual(-6, result[4, 1]);
            Assert.AreEqual(-17, result[4, 2]);
            Assert.AreEqual(18, result[4, 3]);
            Assert.AreEqual(-19, result[4, 4]);
        }

        [TestMethod]
        public void ValidMatrixSize()
        {
            DataService ds = new DataService();

            int[,] matrix = ds.GetTestMatrix();
            int[,] result = ds.Calculate(matrix);

            Assert.AreEqual(5, result.GetLength(0)); 
            Assert.AreEqual(5, result.GetLength(1)); 
        }

        [TestMethod]
        public void ValidOnlyThirdRowChanged()
        {
            DataService ds = new DataService();

            int[,] matrix = ds.GetTestMatrix();
            int[,] result = ds.Calculate(matrix);

            for (int i = 0; i < 5; i++)
            {
                if (i != 2) 
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Assert.AreEqual(matrix[i, j], result[i, j]);
                    }
                }
            }
        }

        [TestMethod]
        public void ValidEvenNumbersInThirdRow()
        {
            DataService ds = new DataService();

            int[,] matrix = ds.GetTestMatrix();
            int[,] result = ds.Calculate(matrix);

            Assert.AreEqual(0, result[2, 2]);

            Assert.AreNotEqual(0, result[2, 0]); 
            Assert.AreNotEqual(0, result[2, 1]); 
            Assert.AreNotEqual(0, result[2, 3]); 
            Assert.AreNotEqual(0, result[2, 4]); 
        }

        [TestMethod]
        public void ValidZeroIsEven()
        {
            DataService ds = new DataService();

            int[,] testMatrix = new int[5, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 0, 1, 2, 3, 4 }, 
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 }
            };

            int[,] result = ds.Calculate(testMatrix);

            // Проверяем третью строку
            Assert.AreEqual(0, result[2, 0]); 
            Assert.AreEqual(1, result[2, 1]);
            Assert.AreEqual(0, result[2, 2]); 
            Assert.AreEqual(3, result[2, 3]); 
            Assert.AreEqual(0, result[2, 4]); 
        }
    }
}