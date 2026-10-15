using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint2.Task3.V20.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(18.000, ds.Calculate(2), 0.0001);
            Assert.AreEqual(16.771, ds.Calculate(1.5), 0.0001);
            Assert.AreEqual(0.750, ds.Calculate(0), 0.0001);
            Assert.AreEqual(2.000, ds.Calculate(1), 0.0001);
            Assert.AreEqual(0.640, ds.Calculate(-2), 0.0001);
            Assert.AreEqual(-274.960, ds.Calculate(-25), 0.0001);
        }
    }
}
