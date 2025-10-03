using Tyuiu.DolganovAV.Sprint2.Task7.V2.Lib;
namespace Tyuiu.DolganovAV.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.5;
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.7;
            bool wait = false;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
