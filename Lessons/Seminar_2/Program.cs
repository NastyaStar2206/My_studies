/* МЕТОДЫ.

Задача: Написать программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.
*/
/*
int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);
    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    return result;
}


int number = CutNumber();
Console.WriteLine("Result number is " + number);

void CutNumberVoid()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    Console.WriteLine("Result number is " + result);
}


CutNumberVoid();
*/

/* 
Задача: Написать программу, которая выводит случайное число из отрезка от 10 до 99 
и показывает наибольшую цифру этого числа.
*/
/*
int MaxNumber()
{
    int num = new Random().Next(10, 100);

    Console.WriteLine(num);

    int num1 = num /10;
    int num2 = num % 10;

    if(num1 > num2)
        return num1;
    else
        return num2;
}

int result = MaxNumber();
Console.Write(result);
*/

/* 
Задача: Написать программу, которая принимает на вход число 
и проверяет кратно ли оно одновременно 7 и 23.
*/
/*
void CutNumberVoid()
{
    int num = new Random().Next();
    Console.WriteLine("Current random number is " + num);

    if(num % 7 == 0)
    {
        if(num % 23 == 0)
        {
            Console.WriteLine("Число является кратным 7 23");
        }
    }
    else
    {
        Console.WriteLine("Число не является кратным 7 и 23");
    }
}
CutNumberVoid();
*/
/*
Задача: Написать программу, которая принимает на вход два числа 
и проверяет является ли одно число квадратом другого.
*/
/*
void IsQuad(int num1, int num2)
{
        int quad2 = num2 * num2;
        int quad1 = num1 * num1;

        if (num1 == quad2)
        {
            Console.WriteLine("Yes");
        }
        else
            if(num2 == quad1)
            {
                Console.WriteLine("Yes");
            }
            else
                {
                    Console.WriteLine("No");
                }
}
*/




