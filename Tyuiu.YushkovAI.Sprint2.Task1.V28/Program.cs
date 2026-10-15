using Tyuiu.YushkovAI.Sprint2.Task1.V28.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                            *");
            Console.WriteLine("* Тема: Логические операции                                                                            *");
            Console.WriteLine("* Задание #1                                                                                           *");
            Console.WriteLine("* Вариант #28                                                                                          *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу с операциями сравнения и логическими операциями.                                  *");
            Console.WriteLine("* Операции сравнения: ==, !=, <, >, <=, >=.                                                           *");
            Console.WriteLine("* Логические операции в порядке: |, &, ||, &&, !, ^.                                                   *");
            Console.WriteLine("* Получить массив: True, False, True, False, True, False.                                              *");
            Console.WriteLine("* При a = 247, b = 654, c = 671, d = 671.                                                              *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;

            Console.WriteLine("Значение a: " + a);
            Console.WriteLine("Значение b: " + b);
            Console.WriteLine("Значение c: " + c);
            Console.WriteLine("Значение d: " + d);

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: (" + result[0] + ", " + result[1] + ", " + result[2] + ", " + result[3] + ", " + result[4] + ", " + result[5] + ")");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
