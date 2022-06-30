/* Задача 1: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
int num1, num2;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("max = " + num2); 
}
*/

/*Задача 2: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
int num1, num2, num3;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
if(num3 > max) max = num3;


Console.Write("max = ");
Console.Write(max);
*/

/*Задача 3: 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*int num, del;

Console.Write("Input a num: ");
num = Convert.ToInt32(Console.ReadLine());

del = num / 2;

if(del * 2 == num)

{
    Console.WriteLine(num + " четное");
}
else
{
    Console.WriteLine(num + " нечетное");
}
*/

/* Задача 4: 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;

if (N < 2)
{
    Console.Write("Введите число не меньше 2: ");
}

while (current<=N)
{
    Console.Write(current+ " ");
    current = current+2;
}
