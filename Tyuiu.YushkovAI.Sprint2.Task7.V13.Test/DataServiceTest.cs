
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint2.Task7.V13.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void TestBlackArea()
        {
            double x = 0.5;
            double y = -0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestWhiteArea()
        {
            double x = 1.5;
            double y = 0;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.IsFalse(res);
        }
    }
}
