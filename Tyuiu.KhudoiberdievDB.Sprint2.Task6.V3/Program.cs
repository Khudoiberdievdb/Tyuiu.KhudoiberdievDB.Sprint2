using Tyuiu.KhudoiberdievDB.Sprint2.Task6.V3.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task6.V3
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
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #3                                                                   *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Составить программу, которая в зависимости от порядкового номера дня недели  *");
            Console.WriteLine("* (1, 2, …, 7) выводит на экран его название (понедельник, …, воскресенье).    *");



            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите порядковый номер дня недели");
            int numDay = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numDay <= 0) || (numDay >= 8))
            {
                res = "В неделе 7 дней";
            }
            else
            {
                 res = "День недели - " + ds.FindDayName(numDay);
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();



        }
    }
}
