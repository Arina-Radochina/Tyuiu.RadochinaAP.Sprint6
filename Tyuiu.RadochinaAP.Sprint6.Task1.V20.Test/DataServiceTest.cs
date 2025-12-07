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

            Assert.AreEqual(-26.10, result[0], 0.01); 

            Assert.AreEqual(-3.00, result[5]);

            
            Assert.AreEqual(24.14, result[10], 0.01);
        }
    }
}