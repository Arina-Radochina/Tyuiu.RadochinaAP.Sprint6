using Tyuiu.RadochinaAP.Sprint6.Task7.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
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

            Assert.AreEqual(14, result[4, 0]); 
            Assert.AreEqual(9, result[4, 1]);  
            Assert.AreEqual(9, result[4, 2]);  
            Assert.AreEqual(20, result[4, 3]); 
            Assert.AreEqual(5, result[4, 4]);  
            Assert.AreEqual(0, result[4, 5]);  
            Assert.AreEqual(5, result[4, 6]);  
            Assert.AreEqual(1, result[4, 7]);  
            Assert.AreEqual(9, result[4, 8]);  
            Assert.AreEqual(9, result[4, 9]); 

            Assert.AreEqual(-14, result[0, 7]); 
            Assert.AreEqual(-15, result[1, 0]);
            Assert.AreEqual(-19, result[6, 1]); 
        }

        [TestMethod]
        public void TestEmptyLinesAtEnd()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "1;2;3\n4;5;6\n7;8;9\n\n\n");

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
        public void TestNoFifthRow()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int[,] result = ds.ReplaceZerosInSecondColumn(matrix);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(matrix[i, j], result[i, j]);
                }
            }
        }
    }
}