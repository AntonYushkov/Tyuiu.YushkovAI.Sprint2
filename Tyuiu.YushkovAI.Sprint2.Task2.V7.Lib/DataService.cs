using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovAI.Sprint2.Task2.V7.Lib
{
    public class DataService : ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (
                (y >= 3 && y <= 4 &&
                    ((x >= 3 && x <= 5) || (x >= 9 && x <= 12))) ||

                (y == 5 && x >= 3 && x <= 12) ||

                (y >= 6 && y <= 7 && x >= 3 && x <= 13) ||

                (y == 8 && x >= 4 && x <= 13) ||

                (y >= 9 && y <= 10 &&
                    ((x >= 4 && x <= 5) || (x >= 10 && x <= 12))) ||

                (y == 11 &&
                    ((x >= 3 && x <= 5) || (x >= 10 && x <= 12))) ||

                (y == 12 &&
                    ((x >= 4 && x <= 6) || x == 10)) ||

                (y == 13 && x >= 4 && x <= 6)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
