// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
// N = 4532 -> 4
/*
int DigitsCount(int N)
{
    if(N>9)
    {
        
        return 1 + DigitsCount(N/10);
    }
   else
    return 1;
}
Console.WriteLine(DigitsCount(230043));
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30.

/*
int SumOfRange(int M, int N)
{
    if(M<N)
    {
        return M + SumOfRange(M+1, N);
    }
    else
        return M;
}   

Console.WriteLine(SumOfRange(3, 8));
*/