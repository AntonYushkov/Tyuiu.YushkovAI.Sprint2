using Tyuiu.YushkovAI.Sprint2.Task5.V15.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k от 1 до 365.                                         *");
            Console.WriteLine("* Определить день недели для k-го дня невисокосного года,                 *");
            Console.WriteLine("* в котором 1 января является понедельником.                              *");
            Console.WriteLine("* Использовать оператор switch.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение k (от 1 до 365):");
            int k = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDayName(k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"День недели: {result}");
        }
    }
}
