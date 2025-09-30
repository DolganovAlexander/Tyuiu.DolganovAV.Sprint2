using Tyuiu.DolganovAV.Sprint2.Task6.V13.Lib;
namespace Tyuiu.DolganovAV.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2025;
            int m = 2;
            int n = 29;
            Assert.AreEqual("1.3.2025", ds.FindDateOfNextDay(g, m, n));
        }
    }
}
