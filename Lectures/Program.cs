/*Функции и массивы

Функции в жизни: 
* Поставь будильник на 19:00
* Купи продукты для борща
* Испеки блины
* Приготовь омлет
* Помой посуду
Функции в программировании:
1) f(x)=x²+1, y=x²+1
2) f(5)=5²+1
   f(5)=26
3) Next(1,10);
   WriteLine("Привет");

Функция - это часть программного кода, который создает разработчик.
* функция имеет идентификатор (имя)
  для именования функции используются такие же принципы, как и для переменных (латинские символы, цифры (цифра не может стоять на первом месте));
* может иметь входные аргументы
* может возвращать значение. В общем случае она может и не возвращать их, тогда в некоторых языках такие конструкции называются процедурами. 
В языке С# не принято разделение на функции и процедуры, а просто говорится МЕТОД. Метод либо возвращает значение, либо не возвращает.

Общее описание функции в контексте языка С#:
// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента, ...])
{
    ТелоМетода
    return ЗначениеСоответствующееВозвращаемомуТипуДанных;
}
Пример:
классический
f(x)=x²+1
Язык программирования  double f(double x)
{
    double result = x*x+1;
    return result
} 

Задача: Найти максимальное из 9 чисел
*/
/*
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
*/
// Решение с помощью функции:
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 3945;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);
/*

// ИСПОЛЬЗОВАНИЕ МАССИВОВ.

ТИП ДАННЫХ[] ИМЯ = {Значение1,Значение2,...}
int[] array = {9,28,1,32,1990}

int[] array = {0,0,0,0,0}
int[] array = new int[5];
int[] array = new int[]{0,0,0,0,0}
int[] array = new int[5]{1,0,2,0,3}
*/
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//    индекс ->  0   1   2   3   4   5   6   7   8
int[ ] array = {11, 12, 43, 75, 25, 46, 17, 28, 39};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.Write(result);
/*
//Задача: Поиск позиции нужного нам элемента.
Имеется одномерный массив array из n элементов, требуется
найти элемент массива, равный find.
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу
успешно.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае
алгоритм завершил работу безуспешно.
*/
/*
int[] array = {1, 4, 31, 4, 15, 16, 17, 4};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
   if(array[index] == find)
   {
    Console.WriteLine(index);
    break;
   } 
    //index = index + 1;
    index++;
}
/*
// Теперь перепишем этот код с использованием генератора псевдослучайных чисел и методов. 
* Потренируем то, каким образом можно взять метод, передать в него массив и заполнить массив нужным количеством элементов.
* На следующем этапе опишем метод, который будет выводить все элементы по порядку.
* На следующем этапе превратим код поиска нужного нам индекса в метод.
*/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);