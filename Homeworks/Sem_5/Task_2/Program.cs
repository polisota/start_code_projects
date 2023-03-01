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

Console.WriteLine("Задача 36\nЗадайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

int[] array = FillArray(10, -100, 101);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2 == 1)
    {
        sum += array[i];
    }
}
Console.WriteLine($"[{string.Join(", ", array)}] \nСумма чисел, стоящих на нечётных позициях = {sum}.");
