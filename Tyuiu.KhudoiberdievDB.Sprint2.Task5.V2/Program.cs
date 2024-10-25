using Tyuiu.KhudoiberdievDB.Sprint2.Task5.V2.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #2                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #5                                                                   *");
Console.WriteLine("* Вариант #2                                                                   *");
Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет             *");
Console.WriteLine("* требуемое значение и возвращает результат.                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");


Console.WriteLine("Введите номер месяца : ");
int value = Convert.ToInt32(Console.ReadLine());

string res;

if ((value < 1) || (value > 12))

{
    res = "Вы ввели неверное значение!";
}
else
{
    if ((value >= 1) && (value <= 2) || (value == 12))
    {
        res = ds.FindMonthSeason(value) + " - Зимний месяц";
    }
    else
    {
        if ((value >= 3) && (value <= 5))
        {
            res = ds.FindMonthSeason(value) + " - Весенний месяц";

        }
        else
        {
            if ((value >= 6) && (value <= 8))
            {
                res = ds.FindMonthSeason(value) + " - Летний месяц";
            }
            else
            {
                if ((value >= 9) && (value >= 11))
                {
                    res = ds.FindMonthSeason(value) + " - Осенний месяц";
                }
                else
                {
                    res = ds.FindMonthSeason(value) + " - Осенний месяц";

                }

            }
        }

    }


}

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(res);
Console.ReadKey();

