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
                // Создаем файл с числами, кратными 5
                File.WriteAllText(testFile, "10\n20\n30\n7\n8");

                double[] result = ds.LoadFromDataFile(testFile);

                // Должны вернуться только 10, 20, 30 (кратные 5)
                Assert.AreEqual(3, result.Length);
                Assert.AreEqual(10.0, result[0]);
                Assert.AreEqual(20.0, result[1]);
                Assert.AreEqual(30.0, result[2]);
            }
            finally
            {
                if (File.Exists(testFile))
                    File.Delete(testFile);
            }
        }

        [TestMethod]
        public void Test3_EmptyArray()
        {
            DataService ds = new DataService();
            string testFile = "test_empty.txt";

            try
            {
                File.WriteAllText(testFile, "7\n13\n22");

                double[] result = ds.LoadFromDataFile(testFile);

                // Ни одно число не кратно 5
                Assert.AreEqual(0, result.Length);
            }
            finally
            {
                if (File.Exists(testFile))
                    File.Delete(testFile);
            }
        }

        [TestMethod]
        public void Test4_NegativeNumbers()
        {
            DataService ds = new DataService();
            string testFile = "test_negative.txt";

            try
            {
                File.WriteAllText(testFile, "-5\n-10\n-15\n-3\n-7");

                double[] result = ds.LoadFromDataFile(testFile);

                // Кратные 5: -5, -10, -15
                Assert.AreEqual(3, result.Length);
            }
            finally
            {
                if (File.Exists(testFile))
                    File.Delete(testFile);
            }
        }

        [TestMethod]
        public void Test5_FileNotFound()
        {
            DataService ds = new DataService();
            string nonExistentFile = "this_file_does_not_exist_12345.txt";

            Assert.ThrowsException<Exception>(() =>
            {
                ds.LoadFromDataFile(nonExistentFile);
            });
        }

        [TestMethod]
        public void Test6_Rounding()
        {
            DataService ds = new DataService();
            string testFile = "test_rounding.txt";

            try
            {
                // 15.12345 - не кратно 5 (остаток 0.12345)
                // 20.0 - кратно 5
                File.WriteAllText(testFile, "15.12345\n20.0");

                double[] result = ds.LoadFromDataFile(testFile);

                // Только 20.0 должно пройти
                Assert.AreEqual(1, result.Length);
                Assert.AreEqual(20.0, result[0]);
            }
            finally
            {
                if (File.Exists(testFile))
                    File.Delete(testFile);
            }
        }

        [TestMethod]
        public void Test7_DecimalNumbers()
        {
            DataService ds = new DataService();
            string testFile = "test_decimal.txt";

            try
            {
                // 5.0 - кратно 5
                // 10.5 - не кратно 5
                // 15.001 - кратно 5 (с учетом погрешности)
                File.WriteAllText(testFile, "5.0\n10.5\n15.001");

                double[] result = ds.LoadFromDataFile(testFile);

                // Должны вернуться 5.0 и 15.001
                Assert.AreEqual(2, result.Length);
            }
            finally
            {
                if (File.Exists(testFile))
                    File.Delete(testFile);
            }
        }
    }
}