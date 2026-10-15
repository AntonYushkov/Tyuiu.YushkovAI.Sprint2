using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovAI.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[]
            {
                (a < b) | (c == d),
                (a > b) & (c != d),
                (a <= b) || (c > d),
                (a >= b) && (c < d),
                !(a > b),
                (a < b) ^ (c == d)
            };

            return result;
        }
    }
}
