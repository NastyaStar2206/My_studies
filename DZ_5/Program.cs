//Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size, int minVaiue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)   
        newArray[i] = new Random().Next(100, 1000);

    return newArray;
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
PrintResult(array);
 */

 //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 //[3, 7, 23, 12] -> 19
 //[-4, -6, 89, 6] -> 0

/*
 int[] CreateRandomArray(int size, int minVaiue, int maxValue)
{
    int[] newArray = new int[size]; // эта строка инициализирует массив newArray.

    for(int i = 0; i < size; i++)   // i+=2 - если надо будет пройтись почетным элементам массива (с шагом через один).
        newArray[i] = new Random().Next(minVaiue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


int FindUnevenSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        //if(array[i] > 0) sum += array[i];
        if (i % 2 > 0) sum += array[i];
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfUneven = FindUnevenSum(array);
Console.WriteLine("Sum of uneven elements in current array is " + sumOfUneven);
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();

    Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    Console.WriteLine();
}

int size = new Random().Next(1, 11);

Console.WriteLine($"Количество элементов массива: {size}");
PrintDiffMinMax(FillSourceArray(size));
Console.WriteLine();

*/