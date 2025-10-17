using Tyuiu.RadchenkoAV.Sprint2.Task7.V15.Lib;
namespace Tyuiu.RadchenkoAV.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            double x = 1.2;
            double y = 1.2;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
