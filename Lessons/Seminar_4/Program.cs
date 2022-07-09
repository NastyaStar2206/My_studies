// Написать программу, которая принимает на вход некоторое число и выдает сумму чисел от 1 до а.
/*
int FindSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
        sum += current; // sum = sum + current;

    return sum;
}

Console.Write("Введите положительное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {num} это {FindSum(num)}");
*/

// Написать программу, которая принимает на вход число и показывает сколько цифр в этом числе.
/*
int Kolich(int num)
{
    int result = 1;
    int i = 1;
    while(num / i > 10)
    {
        i = i * 10;
        result++;
    }
    return result;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Kolich(n));
*/

// Написать программу, которая принимает на вход некоторое число N и выдает произведение чисел от 1 до N.
/*
int Proisv(int N)
{
    int result = 1;
    for(int i = 1; i<=N; i++)
        result = result * i;
    return result;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proisv(n));
*/

// Написать программу, которая принимает на вход два числа а и b и возводит число а в степень b. 
/*
int Step(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
        result = result * a;
    return result;
}
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Step(n, m));
*/
