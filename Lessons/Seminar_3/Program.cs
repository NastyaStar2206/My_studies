/*
Написать программу, которая принимает на вход номер четверти и выводит диапазон значений координат возможных в этой четверти.
*/
/*
void ShowArea(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
        if(quart == 1) Console.WriteLine("In this quart x > 0 and y > 0");
        if(quart == 2) Console.WriteLine("In this quart x < 0 and y > 0");
        if(quart == 3) Console.WriteLine("In this quart x < 0 and y < 0");
        if(quart == 4) Console.WriteLine("In this quart x > 0 and y < 0");
    }
    else
    Console.WriteLine("This number is uncorrect!");
}


Console.Write("Input number of quart: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);
*/

//Написать программу, которая принимает на вход координаты точки и выдает номер четверти, в которой эта точка находится.

/*
int Quart(int x, int y)
{
    int result = -1;

    if(x > 0 && y > 0) result = 1;
    if(x < 0 && y > 0) result = 2;
    if(x < 0 && y < 0) result = 3;
    if(x > 0 && y < 0) result = 4;
    return result;    
}

Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Номер четверти: " + Quart(x, y));
*/


//Написать программу, которая принимает на вход число n (целочисленное) и возвращает квадраты всех чисел от 1 до n.
/*
void Quad(int x)
{
    int current = 1;
    while (current <= x)
    {
        int quad = current*current;
        Console.Write(quad + "");
        current ++;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Quad(n);
*/