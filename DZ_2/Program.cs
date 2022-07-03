/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
void CutNumberVoid()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

        int ed = num /10 % 10;

    int result = ed;
    Console.WriteLine("Result number is " + result);
}

CutNumberVoid();
*/
/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
void CutNumberVoid()
{
    Console.Write("Input a num: ");
    int num = Convert.ToInt32(Console.ReadLine());

        if(num <= 99)
        {
            Console.WriteLine("У числа нет третьей цифры");
        }
        else    
            if(num <= 999)
            {
                Console.WriteLine("Третьей цифрой числа является " +  num % 10);
            }
            else
                if(num <= 9999)
                {
                    Console.WriteLine("Третьей цифрой числа является " +  num / 10 % 10);
                }
                else
                    if(num <= 99999)
                    {
                        Console.WriteLine("Третьей цифрой числа является " +  num / 100 % 10);
                    }      
                    else
                        if(num <= 999999)
                        {
                            Console.WriteLine("Третьей цифрой числа является " +  num / 1000 % 10);
                        }             
                
}

CutNumberVoid();
*/

/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
    int DayNumber()
{
    int num = new Random().Next(1,8);
    Console.WriteLine("Current random number is " + num);
    
    int result = num;

    if(num == 1)
    {
        Console.Write(num + " - это понедельник.");
    }
    if(num == 2)
    {
        Console.Write(num + " - это вторник.");
    }
    if(num == 3)
    {
        Console.Write(num + " - это среда.");
    }
    if(num == 4)
    {
        Console.Write(num + " - это четверг.");
    }if(num == 5)
    {
        Console.Write(num + " - это пятница.");
    }
    if(num == 6)
    {
        Console.Write(num + " - суббота.");
    }
    if(num == 7)
    {
        Console.Write(num + " - воскресенье.");
    }
    
        if(num > 5)
        {
           Console.Write(" Ура! Это выходной день!");  
        }
        else
            {
                Console.Write(" Рабочий день.");
            }
        return(result);
}

DayNumber();
*/