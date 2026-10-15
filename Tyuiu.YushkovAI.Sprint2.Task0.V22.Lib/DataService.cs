using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovAI.Sprint2.Task0.V22.Lib
{
    public class DataService : ISprint2Task0V22
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[]
            {
                x == y,
                x != y,
                x < x + y,
                x > y,
                x <= x + y,
                x >= x + y
            };

            return result;
        }
    }
}
