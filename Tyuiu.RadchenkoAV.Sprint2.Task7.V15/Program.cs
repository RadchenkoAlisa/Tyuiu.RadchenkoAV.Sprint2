using System.Runtime.InteropServices;
using Tyuiu.RadchenkoAV.Sprint2.Task7.V15.Lib;
Console.Title = "Спринт #2| Выполнил: Радченко А. В. | РППБ-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #15                                                              *");
Console.WriteLine("* Выполнил: Радченко А. В.| РППБ-25-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции  с     *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
Console.WriteLine("* переменных x,y с клавиатуры.                                            *");
Console.WriteLine("***************************************************************************");
DataService ds = new();
double x;
double y;
Console.WriteLine("введите значение х: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение y: ");
y = Convert.ToDouble(Console.ReadLine());
bool res = ds.CheckDotInShadedArea(x, y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (res == true)
{
    Console.WriteLine("Точка находится в заштрихованной области.");
}
else
{
    Console.WriteLine("Точка не находится в заштрихованной области.");
}
Console.ReadKey();