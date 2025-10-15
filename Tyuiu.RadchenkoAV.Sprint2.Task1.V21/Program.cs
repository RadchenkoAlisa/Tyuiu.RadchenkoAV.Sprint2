
using System.Runtime.InteropServices;
using Tyuiu.RadchenkoAV.Sprint2.Task1.V21.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2| Выполнил: Радченко А. В. | РППБ-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #25                                                              *");
Console.WriteLine("* Выполнил: Радченко А. В.| РППБ-25-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать консольную программу на C#, которая вычисляет значение         *");
Console.WriteLine("* логических выражений                                                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: x = 205 y = 159                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int a = 696;
int b = 987;
int c = 696;
int d = 155;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();