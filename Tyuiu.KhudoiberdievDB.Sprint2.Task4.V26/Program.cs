using Tyuiu.KhudoiberdievDB.Sprint2.Task4.V26.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #26                                                                  *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием    *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");


            Console.WriteLine("Введите зачение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите зачение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            var res = ds.Calculate(x, y);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Значение = " + res);
            Console.ReadKey();
        }
    }
}
