
using Tyuiu.YushkovAI.Sprint2.Task2.V7.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            // Закрашенные клетки
            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 3));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(5, 4));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(9, 3));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(12, 4));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(7, 5));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(13, 6));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 7));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(13, 8));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(4, 9));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(12, 10));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 11));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(10, 12));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(6, 13));

            // Незакрашенные клетки
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(7, 3));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(8, 4));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(13, 5));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(14, 6));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(3, 8));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(8, 9));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(9, 10));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(6, 11));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(9, 12));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(10, 13));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(4, 14));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(16, 6));
        }
    }
}
