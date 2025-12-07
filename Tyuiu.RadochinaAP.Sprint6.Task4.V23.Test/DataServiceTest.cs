using Tyuiu.RadochinaAP.Sprint6.Task4.V23.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);
        }

        [TestMethod]
        public void SimpleDivisionByZeroTest()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(1, 1);

            Assert.AreEqual(1, result.Length);
        }

        [TestMethod]
        public void SimpleSaveToFile()
        {
            DataService ds = new DataService();

            double[] testData = { 1.1, 2.2, 3.3 };

            string testFile = "test_output.txt";

            try
            {
                ds.SaveToFile(testFile, testData, 0, 2);

                Assert.IsTrue(File.Exists(testFile));
            }
            finally
            {
                if (File.Exists(testFile))
                {
                    File.Delete(testFile);
                }
            }
        }

        [TestMethod]
        public void SimpleArrayTest()
        {
            DataService ds = new DataService();

            double[] r1 = ds.GetMassFunction(1, 5);
            Assert.AreEqual(5, r1.Length);

            double[] r2 = ds.GetMassFunction(-2, 2);
            Assert.AreEqual(5, r2.Length);
        }
    }
}