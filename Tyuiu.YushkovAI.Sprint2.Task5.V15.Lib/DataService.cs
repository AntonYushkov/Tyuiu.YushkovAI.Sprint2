using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovAI.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            string result;

            switch (k % 7)
            {
                case 1:
                    result = "Понедельник";
                    break;
                case 2:
                    result = "Вторник";
                    break;
                case 3:
                    result = "Среда";
                    break;
                case 4:
                    result = "Четверг";
                    break;
                case 5:
                    result = "Пятница";
                    break;
                case 6:
                    result = "Суббота";
                    break;
                case 0:
                    result = "Воскресенье";
                    break;
                default:
                    result = "Неизвестный день";
                    break;
            }

            return result;
        }
    }
}
