using System;
using Tyuiu.RadochinaAP.Sprint6.Task0.V3.Lib;

namespace Tyuiu.RadochinaAP.Sprint6.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int x = 3;
            double result = ds.Calculate(x);

            double wait = 4.154;

            Assert.AreEqual(wait, result, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InvalidCalculate()
        {
            DataService ds = new DataService();

            int x = 1;
            double result = ds.Calculate(x);
        }
    }
}
