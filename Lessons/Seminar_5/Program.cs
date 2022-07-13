
// 1. Метод создания массива, который генерируется автоматически.

/*

int[] CreateRandomArray(int size, int minVaiue, int maxValue)
{
    int[] newArray = new int[size]; // эта строка инициализирует массив newArray.

    for(int i = 0; i < size; i++)   // i+=2 - если надо будет пройтись почетным элементам массива (с шагом через один).
        newArray[i] = new Random().Next(minVaiue, maxValue + 1);

    return newArray;
}

// 2. Метод создания массива, с помощью ручного ввода.

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

// 3. Метод, который будет печатать массив.

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

// Задача: Задать массив от 12 элементов, заполненный случайными числами с промежутком от -9 до 9 и найти сумму положительных элементов данного массива.

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];

    return sum;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());


//int[] array1 = CreateRandomArray(size, min, max);     //для сгенерированного метода
//int[] array2 = CreateArray(size);                     //для метода ручного ввода

//ShowArray(array1);
//ShowArray(array2);

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfPositive = FindPositiveSum(array);
Console.WriteLine("Sum of positiv elements in current array is " + sumOfPositive);

// Работа терминала после запуска программы: 
//Input size of array: 12
//Input min possible value of elements: -9
//Input max possible value of elements: 9
//0 -8 -1 -2 9 9 3 -5 -5 6 6 1 
//Sum of positiv elements in current array is 34
*/

// Задача: Написать программу, которая заменит положительные элементы на отрицательные и наоборот.
/*
int[] CreateRandomArray(int size, int minVaiue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)   
        newArray[i] = new Random().Next(minVaiue, maxValue + 1);

    return newArray;
}

int[] Otric(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    newArray[i] = newArray[i] * -1;

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int[]otric2 = Otric(array);
ShowArray(otric2);

*/
// Задача: Задать массив из 20 случайных чисел, найти кол-во элементов массива, значения которых лежат в отрезке от 10 до 99 включительно.
/*
int[] CreateRandomArray(int size, int minVaiue, int maxValue)
{
    int[] newArray = new int[size]; // эта строка инициализирует массив newArray.

    for(int i = 0; i < size; i++)   // i+=2 - если надо будет пройтись почетным элементам массива (с шагом через один).
        newArray[i] = new Random().Next(minVaiue, maxValue + 1);

    return newArray;
}

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];

    return sum;
}

int FindTwoDigits(int[] array)
{
    int count = 0;

     for(int i = 0; i < array.Length; i++)
        if(array[i] >= 10 && array[i] <= 99) count++;

    return count;
}

int size = 20;
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Count jf two-digit elements is " + FindTwoDigits(array));
*/
