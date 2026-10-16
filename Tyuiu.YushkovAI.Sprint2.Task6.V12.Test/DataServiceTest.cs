
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint2.Task6.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void Default_Day()
        {
            string res = ds.FindDateOfPreviousDay(2024, 10, 15);
            Assert.AreEqual("14.10.2024", res);
        }

        [TestMethod]
        public void Previous_Month()
        {
            string res = ds.FindDateOfPreviousDay(2024, 3, 1);
            Assert.AreEqual("29.02.2024", res);
        }

        [TestMethod]
        public void Previous_Year()
        {
            string res = ds.FindDateOfPreviousDay(2024, 1, 1);
            Assert.AreEqual("31.12.2023", res);
        }

        [TestMethod]
        public void Error_Date()
        {
            string res = ds.FindDateOfPreviousDay(2024, 2, 30);
            Assert.AreEqual("Неправильно введена дата", res);
        }
    }
}
