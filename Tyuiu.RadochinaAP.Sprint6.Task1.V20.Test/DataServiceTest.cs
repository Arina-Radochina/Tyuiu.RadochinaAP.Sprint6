using Tyuiu.RadochinaAP.Sprint6.Task1.V20.Lib;
namespace Tyuiu.RadochinaAP.Sprint6.Task1.V20.Test
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

            Assert.AreEqual(-27.22, result[0], 0.01);  
            Assert.AreEqual(-22.25, result[1], 0.01);  
            Assert.AreEqual(-16.66, result[2], 0.01);  
            Assert.AreEqual(-11.04, result[3], 0.01);  
            Assert.AreEqual(-6.13, result[4], 0.01);   
            Assert.AreEqual(-3.00, result[5], 0.01);   
            Assert.AreEqual(4.84, result[6], 0.01);    
            Assert.AreEqual(8.86, result[7], 0.01);    
            Assert.AreEqual(14.43, result[8], 0.01);   
            Assert.AreEqual(20.18, result[9], 0.01);   
            Assert.AreEqual(25.24, result[10], 0.01);  
        }

        [TestMethod]
        public void ValidSingleValue()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(0, 0);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(-3.00, result[0], 0.01);

            result = ds.GetMassFunction(3, 3);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(14.43, result[0], 0.01);

            result = ds.GetMassFunction(-2, -2);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(-11.04, result[0], 0.01);
        }
    }
}