using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovAI.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            double result;

            if (x > 1)
            {
                result = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    double x2 = Math.Pow(x, 2);

                    result = (x2 - Math.Cos(x2) + 10) /
                             (x2 - Math.Sin(x2) + 12);
                }
                else
                {
                    if (x > -24 && x < 2)
                    {
                        result = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
                    }
                    else
                    {
                        if (x < -24)
                        {
                            result = x + 10 * x - 1 / x;
                        }
                        else
                        {
                            result = double.NaN;
                        }
                    }
                }
            }

            return Math.Round(result, 3);
        }
    }
}
