using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovAI.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (g < 1 || m < 1 || m > 12)
            {
                return "Неправильно введена дата";
            }

            int daysInMonth = m switch
            {
                2 => 29,
                4 => 30,
                6 => 30,
                9 => 30,
                11 => 30,
                _ => 31
            };

            if (n < 1 || n > daysInMonth)
            {
                return "Неправильно введена дата";
            }

            if (g == 1 && m == 1 && n == 1)
            {
                return "Неправильно введена дата";
            }

            if (n > 1)
            {
                n = n - 1;
            }
            else
            {
                m = m - 1;

                if (m == 0)
                {
                    m = 12;
                    g = g - 1;
                }

                n = m switch
                {
                    2 => 29,
                    4 => 30,
                    6 => 30,
                    9 => 30,
                    11 => 30,
                    _ => 31
                };
            }

            return $"{n:D2}.{m:D2}.{g:D4}";
        }
    }
}
