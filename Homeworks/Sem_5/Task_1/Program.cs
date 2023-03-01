int[] FillArray(int n, int k1, int k2)
{
    int[] a = new int[n];
    Random rnd = new Random();
    for (int i = 0; i<n; i++)
    {
        a[i] = rnd.Next(k1, k2);

    }
    return a;    
}

Console.Clear();

Console.WriteLine("Задача 34\nЗадайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

int[] array = FillArray(15, 100, 1000);
int i = 0;
foreach (int element in array)
{
    if(element % 2 == 0)
        i++;
}
Console.WriteLine($"[{string.Join(", ", array)}] \nЧисло четных чисел = {i}.");