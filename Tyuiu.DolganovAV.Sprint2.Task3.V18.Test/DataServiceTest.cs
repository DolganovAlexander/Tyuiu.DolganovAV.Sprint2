using Tyuiu.DolganovAV.Sprint2.Task3.V18.Lib;
namespace Tyuiu.DolganovAV.Sprint2.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int x = 5;
            Assert.AreEqual(189.844, ds.Calculate(x));
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            int x = 0;
            Assert.AreEqual(0.750, ds.Calculate(x));
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            int x = -11;
            Assert.AreEqual(0.913, ds.Calculate(x));
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            int x = -30;
            Assert.AreEqual(-329.967, ds.Calculate(x));
        }
    }
}
