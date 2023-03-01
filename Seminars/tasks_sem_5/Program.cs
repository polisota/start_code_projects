Console.Clear();

int[] FillArray(int n, int k1, int k2)
{
    int[] r = new int[n];
    Random rnd = new Random();

    for (int i = 0; i<n; i++)
    {
        r[i] = rnd.Next(k1, k2);

    }

    return r;
    
}

//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
int [] array = FillArray(12, -9, 9);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int sumNegative = 0, sumPositive = 0;
foreach(int element in array)
{
    if (element > 0)
        sumPositive += element;
    else
        sumNegative += element;
}
Console.WriteLine($"Сумма отрицательных: {sumNegative} Сумма положительных: {sumPositive}");

//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] arr1 = FillArray(10, -10, 10);
Console.WriteLine($"Начальный массив: [{string.Join(", ", arr1)}]");
for(int j = 0; j > arr1.Length; j++)
    arr1[j] *= (-1);
Console.WriteLine($"Конечный массив: [{string.Join(", ", arr1)}]");

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Console.Write("Введите число: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] ar = FillArray(10, -10, 10);
Console.WriteLine($"Mассив: [{string.Join(", ", ar)}]");
bool flag = true;
int l = 0;
while (flag && l < ar.Length)
{
    if (array[l] == s)
        flag = false;
    l++;
}
if (flag)
    Console.WriteLine("no");
else
    Console.WriteLine("yes");

//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] a = FillArray(123, -100, 100);
Console.WriteLine($"Mассив: [{string.Join(", ", a)}]");
int v = 0;
foreach (int elem in a)
{
    if (elem >= 10 && elem <= 99)
        v++;
}
Console.WriteLine(v);

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
//и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
Console.Write("Введите число: ");
int e = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[e];
for (int x = 0; x < array1.Length; x++)
    array1[x] = new Random().Next(1, 11); // [1, 10]

Console.WriteLine($"Начальный массив: [{string.Join(", ", array1)}]");
int[] resultArray = new int[e / 2 + e % 2];
for (int x = 0; x < resultArray.Length; x++)
{
    resultArray[x] = array1[x] * array1[array1.Length - 1 - x];
}
Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");