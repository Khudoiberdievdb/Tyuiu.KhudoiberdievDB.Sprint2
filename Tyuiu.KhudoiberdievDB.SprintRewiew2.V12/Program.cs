namespace Tyuiu.KhudoiberdievDB.SprintRewiew2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #SprintRewiew                                                        *");
            Console.WriteLine("* Вариант #12                                                                  *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные и вычисляет,         *");
            Console.WriteLine("* нахожится ли точка с координатами X,Y в закрашенное области                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());


            bool res;
            if ((y >= (2 - x)) && (y <= Math.Pow(x, 2) && (y >= 0) && (x <= 0)) || (Math.Pow(x, 2) >= y) && (y <= (2 - x)) && (x >= 0) && (y >= 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }





            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка находится вне закрашенной области");
            }
            Console.ReadKey();
        }
    }
}
