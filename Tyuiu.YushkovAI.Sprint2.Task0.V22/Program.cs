using Tyuiu.YushkovAI.Sprint2.Task0.V22.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                            *");
            Console.WriteLine("* Тема: Операции сравнения                                                                             *");
            Console.WriteLine("* Задание #0                                                                                           *");
            Console.WriteLine("* Вариант #22                                                                                          *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу из операций сравнения (==, !=, <, >, <=, >=) и арифметических выражений.           *");
            Console.WriteLine("* Последовательность операций сравнения не должна нарушаться.                                         *");
            Console.WriteLine("* Получить массив: False, True, True, True, True, False.                                               *");
            Console.WriteLine("* При x = 3105, y = 77.                                                                                *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            int x = 3105;
            int y = 77;

            Console.WriteLine("Значение x: " + x);
            Console.WriteLine("Значение y: " + y);

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: (" + result[0] + ", " + result[1] + ", " + result[2] + ", " + result[3] + ", " + result[4] + ", " + result[5] + ")");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
