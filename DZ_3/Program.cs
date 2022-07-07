/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/
/*
Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

void ls5Palindrom(int x)
{
    int first = x / 10000;
    int fifth = x % 10;
    int centre3 = (x % 10000) / 10;
    int second = centre3 / 100;
    int forth = centre3 % 10;

    if(first == fifth && second == forth)
    Console.WriteLine("Палиндром!");
    else
    Console.WriteLine("Не палиндром!");
}

if(N<10000 || N>99999)
Console.Write("Введенное число не пятизначное!");
else
ls5Palindrom(N);
*/
/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
void Cube(int x)
{
    int current = 1;
    while(current<=x)
    {
        int quad = current*current*current;
        Console.Write(quad + "");
        current++;
    }
}
if(N<1)
    Console.Write("Введенное число меньше 1!");
else
    Cube(N);
    */