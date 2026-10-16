using Tyuiu.YushkovAI.Sprint2.Task6.V12.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Даны три натуральных числа: g (год), m (месяц), n (число).              *");
            Console.WriteLine("* Определить дату предыдущего дня.                                        *");
            Console.WriteLine("* Заданный год является високосным.                                       *");
            Console.WriteLine("* Использовать сокращенную форму оператора switch.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год g:");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDateOfPreviousDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Дата предыдущего дня: {result}");
        }
    }
}
