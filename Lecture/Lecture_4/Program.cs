// Двумерные массивы
/*
string[,] table = new string[2,3];

int[,] matrix = new int[5,8]; // где 5 - это строки, 8 столбцы.
*/

/*
string[,] table = new string[2,5];

// String.Empty
// table[0,0]   table[0,1]  table[0,2]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,4]


table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/
/*
int[,] matrix = new int[3,4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
       Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/
/*
int[,] matrix = new int[3,4];

for (int i = 0; i < matrix.GetLength(0); i++)       // заменили цифру на matrix.GetLength(0)
{
    for (int j = 0; j < matrix.GetLength(1); j++)   // заменили цифру на matrix.GetLength(1)
    {
       Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/

// Используем метод.
/*
void PrintArray(int[,] matr)
{
        for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
             Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Заполним матрицу числами.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10)
        }
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

//int[,] matrix = new int[5,8]; // 5 - это строки matrix.GetLength(0)
                                // 8 - это столбцы matrix.GetLength(1)


// КАК ПРЕДСТАВИТЬ ЧЕРНО-БЕЛОЕ ИЗОБРАЖЕНИЕ
/*
int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};
*/
/*
0 - закрашенный пиксель
1 - незарашенный пиксель

как закрасить область?

x-1,y-1            x-1,y (вверх)     x-1,y+1
x,y-1 (влево)      x,y               x,y+1 (вправо)
x+1,y-1            x+1,y (вниз)      x+1,y+1          

*/
//рисуем палец вверх
/*
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
             //Console.Write($"{matr[i, j]} ");
             if(image[i,j] == 0) Console.Write($" ");
             else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

// закрашиваем

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row , col - 1);
        FillImage(row + 1, col);
        FillImage(row , col + 1);
    }
}
PrintImage(pic);
FillImage(13, 15);
PrintImage(pic);
*/

//РЕКУРСИЯ

//Рекурсия - это функция, которая вызывает сама себя.

// Рекурсия вычисления факториала.

/*В математике факториал - произведение чисел от 1 до заданного.
5! = 5*4*3*2*1
    5*4!
        4*3!
            3*2!
                2*1!
*/
// Задача: Определить функцию (метод), который будет принимать число, факториал которого нужно вычислить.
/*
int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(5)); // 1*2*3 = 6
*/
/*int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    //Console.WriteLine(Factorial(i)); //показывает просто факториал.
    Console.WriteLine($"{i}! = {Factorial(i)}"); //показывает факториал какого числа.
}
*/
// получаем отрицательные числа. Такого быть не должно. Это связано с переполнением типа integer.
// В таких случаях используется тип данных double:
/*
double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    //Console.WriteLine(Factorial(i)); //показывает просто факториал.
    Console.WriteLine($"{i}! = {Factorial(i)}"); //показывает факториал какого числа.
}
*/

//Есть ещё матматические функции, которые являются рекурсивными.
/* Это числа ФИБОНАЧЧИ
1 1 2 3 5 8 13 21...

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
*/
/*
int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
*/



