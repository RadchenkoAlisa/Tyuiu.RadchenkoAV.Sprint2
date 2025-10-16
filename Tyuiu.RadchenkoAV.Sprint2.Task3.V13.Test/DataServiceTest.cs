using Tyuiu.RadchenkoAV.Sprint2.Task3.V13.Lib;
namespace Tyuiu.RadchenkoAV.Sprint2.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.75, ds.Calculate(0));
        }
    }
}
