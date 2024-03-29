﻿//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
 volume = 10;                // количество ввода чисел
int count = 0;

while (volume > 0)
{
    Console.Write("Введите число:   ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
    volume--;
}

Console.WriteLine($"Количество чисел больше 0: {count}");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);
    if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
    else
    Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
CrossPoint(k1,b1,k2,b2);