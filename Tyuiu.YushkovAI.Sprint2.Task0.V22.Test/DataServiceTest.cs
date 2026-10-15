using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint2.Task0.V22.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task0.V22.Test
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
                false, true, true, true, true, false
            };

            bool[] actual = ds.GetCompareOperations(3105, 77);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
