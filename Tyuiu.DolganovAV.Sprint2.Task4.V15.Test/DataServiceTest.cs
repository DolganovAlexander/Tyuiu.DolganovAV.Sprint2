using Microsoft.Extensions.DependencyModel;
using Tyuiu.DolganovAV.Sprint2.Task4.V15.Lib;
namespace Tyuiu.DolganovAV.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1() //true
        {
            DataService ds = new DataService();
            double x = 16;
            double y = 16;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(44875795.242, res);
        }
        [TestMethod]
        public void ValidCalculate2() //false
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 625;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.016, res);
        }
    }
}
