// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int sumDigit(int number)

{   
    int sum = 0;
    Console.Write($"Сумма цифр числа {number} равна ");

    while (number > 0)  
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    return sum;
}
int n = new Random().Next(1, 100000);
Console.WriteLine(sumDigit(n));
*/
/* Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

Console.Write("Введите количево элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
PrintArray(SetArray(m));
