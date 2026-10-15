using Tyuiu.YushkovAI.Sprint2.Task3.V20.Lib;

namespace Tyuiu.YushkovAI.Sprint2.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                            *");
            Console.WriteLine("* Тема: Вложенные условные операторы if-else                                                           *");
            Console.WriteLine("* Задание #3                                                                                           *");
            Console.WriteLine("* Вариант #20                                                                                          *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТБ-26-1                                                              *");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
            Console.WriteLine("* Вычислить значение функции Y с использованием вложенных операторов if-else.                           *");
            Console.WriteLine("* Пользователь вводит значение X с клавиатуры.                                                        *");
            Console.WriteLine("* Функция задана четырьмя выражениями для различных диапазонов X.                                     *");
            Console.WriteLine("* Результат округлить до трех знаков после запятой.                                                   *");
            Console.WriteLine("********************************************************************************************************");

            Console.WriteLine();

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x);

            Console.WriteLine();

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {result:F3}");
            Console.WriteLine("********************************************************************************************************");
        }
    }
}
