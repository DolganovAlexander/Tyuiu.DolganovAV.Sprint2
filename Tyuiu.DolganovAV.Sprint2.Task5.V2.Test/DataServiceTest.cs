using Tyuiu.DolganovAV.Sprint2.Task5.V2.Lib;
namespace Tyuiu.DolganovAV.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();
            int value = 5;
            Assert.AreEqual("Весна", ds.FindMonthSeason(value));
        }
    }
}
