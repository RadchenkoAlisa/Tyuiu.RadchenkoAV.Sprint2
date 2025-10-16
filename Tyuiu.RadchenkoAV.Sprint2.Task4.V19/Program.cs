using System.Runtime.InteropServices;
using Tyuiu.RadchenkoAV.Sprint2.Task4.V19.Lib;
Console.Title = "Спринт #2| Выполнил: Радченко А. В. | РППБ-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #25                                                              *");
Console.WriteLine("* Выполнил: Радченко А. В.| РППБ-25-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции  с     *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
Console.WriteLine("* переменных x,y с клавиатуры.                                            *"); Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
DataService ds = new();
double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
do
{
    y = Convert.ToDouble(Console.ReadLine());
    if ((y == 0) && ((x / 2) < (y - 6))) Console.WriteLine("Введите другое значение Y (происходит деление на ноль):");
} while ((y == 0) && ((x / 2) < (y - 6)));
Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();
