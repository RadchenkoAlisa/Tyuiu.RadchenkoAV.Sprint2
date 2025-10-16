using Tyuiu.RadchenkoAV.Sprint2.Task4.V19.Lib;
namespace Tyuiu.RadchenkoAV.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new();
            double x = 2, y = 2;

            Assert.AreEqual(0.874, ds.Calculate(x, y));
        }
    }
}
