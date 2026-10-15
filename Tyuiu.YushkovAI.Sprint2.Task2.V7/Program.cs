using Tyuiu.YushkovAI.Sprint2.Task2.V7.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                            *");
            Console.WriteLine("* Тема: Операторы условия и логические выражения                                                       *");
            Console.WriteLine("* Задание #2                                                                                           *");
            Console.WriteLine("* Вариант #7                                                                                           *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения X и Y с клавиатуры                            *");
            Console.WriteLine("* и определяет, находится ли точка с координатами X, Y в закрашенной области.                           *");
            Console.WriteLine("* Закрашенная область задана рисунком с координатной сеткой 15x15.                                    *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите координату X (номер столбца): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y (номер строки): ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result}");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
