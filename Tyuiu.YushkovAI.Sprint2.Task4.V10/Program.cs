using Tyuiu.YushkovAI.Sprint2.Task4.V10.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                            *");
            Console.WriteLine("* Тема: Тернарный оператор                                                                            *");
            Console.WriteLine("* Задание #4                                                                                           *");
            Console.WriteLine("* Вариант #10                                                                                          *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Вычислить значение функции с использованием тернарного оператора.                                    *");
            Console.WriteLine("* Если 2*x < y/3, то z = (1 + 3/y^2)^x.                                                              *");
            Console.WriteLine("* Иначе z = y + 10*x - 5/x.                                                                            *");
            Console.WriteLine("* Результат округлить до 3 знаков после запятой.                                                       *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result:F3}");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
