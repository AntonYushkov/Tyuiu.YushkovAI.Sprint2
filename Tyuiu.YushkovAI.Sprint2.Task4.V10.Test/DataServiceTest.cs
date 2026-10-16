using Tyuiu.YushkovAI.Sprint2.Task4.V10.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(1.010, ds.Calculate(2, 24), 0.0001);
            Assert.AreEqual(31.333, ds.Calculate(3, 3), 0.0001);
            Assert.AreEqual(0.852, ds.Calculate(-2, 6), 0.0001);
            Assert.AreEqual(11.000, ds.Calculate(1, 6), 0.0001);
            Assert.AreEqual(1.000, ds.Calculate(0, 9), 0.0001);
        }
    }
}
