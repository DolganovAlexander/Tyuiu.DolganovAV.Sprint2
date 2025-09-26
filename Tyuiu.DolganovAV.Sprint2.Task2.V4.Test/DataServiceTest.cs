using Tyuiu.DolganovAV.Sprint2.Task2.V4.Lib;
namespace Tyuiu.DolganovAV.Sprint2.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 9;
            int y = 11;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
        [TestMethod]
        public void ValidCheckDotNotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 6;
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }

    }
}
