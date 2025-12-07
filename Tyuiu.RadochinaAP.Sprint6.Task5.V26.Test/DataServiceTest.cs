using Tyuiu.RadochinaAP.Sprint6.Task5.V26.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.IsNotNull(ds);
        }

        [TestMethod]
        public void Test2_LoadSimpleFile()
        {
            DataService ds = new DataService();

            string testFile = "test_simple.txt";

            try
            {
                File.WriteAllText(testFile, "10.5\n20.3\n30.7");

                double[] result = ds.LoadFromDataFile(testFile);

                Assert.IsTrue(result.Length > 0);
            }
            finally
            {
                if (File.Exists(testFile))
                    File.Delete(testFile);
            }
        }

        [TestMethod]
        public void Test3_FilterSimpleNumbers()
        {
            DataService ds = new DataService();

            double[] testData = { 5, 10, 15, 3, 7 };

            double[] result = ds.FilterNumbersMultipleOfFive(testData);

            Assert.IsNotNull(result);

            Assert.AreEqual(3, result.Length);
        }

        [TestMethod]
        public void Test4_EmptyArray()
        {
            DataService ds = new DataService();

            double[] testData = new double[0];

            double[] result = ds.FilterNumbersMultipleOfFive(testData);

            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void Test5_NegativeNumbers()
        {
            DataService ds = new DataService();

            double[] testData = { -5, -10, -15, -3, -7 };

            double[] result = ds.FilterNumbersMultipleOfFive(testData);

            Assert.AreEqual(3, result.Length);
        }

        [TestMethod]
        public void Test6_FileNotFound()
        {
            DataService ds = new DataService();

            string nonExistentFile = "this_file_does_not_exist_12345.txt";

            try
            {
                double[] result = ds.LoadFromDataFile(nonExistentFile);
                Assert.Fail("Должно было выбросить исключение");
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test7_Rounding()
        {
            DataService ds = new DataService();

            string testFile = "test_rounding.txt";

            try
            {
                File.WriteAllText(testFile, "15.123456\n20.456789");

                double[] result = ds.LoadFromDataFile(testFile);

                Assert.IsTrue(result.Length > 0);
            }
            finally
            {
                if (File.Exists(testFile))
                    File.Delete(testFile);
            }
        }
    }
}