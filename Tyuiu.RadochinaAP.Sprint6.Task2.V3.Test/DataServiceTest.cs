using Tyuiu.RadochinaAP.Sprint6.Task2.V3.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);
           
            Assert.AreEqual(-12.18, result[0], 0.01);

            Assert.AreEqual(-9.99, result[4], 0.01);

            Assert.AreEqual(-2.00, result[5], 0.01);

            Assert.AreEqual(-22.76, result[8], 0.01);
        }

        [TestMethod]
        public void ValidDivisionByZero()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-2, -1);

            Assert.AreEqual(2, result.Length);

        }

        [TestMethod]
        public void ValidEdgeValues()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(-12.18, result[0], 0.01);

            Assert.AreEqual(7.77, result[10], 0.01);
        }

        [TestMethod]
        public void ValidArrayLength()
        {
            DataService ds = new DataService();

            double[] result1 = ds.GetMassFunction(-5, 5);
            Assert.AreEqual(11, result1.Length);

            double[] result2 = ds.GetMassFunction(0, 10);
            Assert.AreEqual(11, result2.Length);

            double[] result3 = ds.GetMassFunction(-3, 3);
            Assert.AreEqual(7, result3.Length);
        }
    }
}
