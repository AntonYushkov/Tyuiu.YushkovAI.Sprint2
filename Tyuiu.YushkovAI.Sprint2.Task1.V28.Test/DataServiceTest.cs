using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint2.Task1.V28.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            bool[] expected = new bool[]
            {
                true, false, true, false, true, false
            };

            bool[] actual = ds.GetLogicOperations(247, 654, 671, 671);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
