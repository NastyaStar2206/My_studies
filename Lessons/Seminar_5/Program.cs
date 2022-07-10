// Задача: Задать массив от 12 элементов, заполненный случайными числами с промежутком от -9 до 9 и найти сумму положительных элементов данного массива.

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

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] array1 = CreateRandomArray(size, min, max);
int[] array2 = CreateArray(size);

ShowArray(array1);
ShowArray(array2);

*/