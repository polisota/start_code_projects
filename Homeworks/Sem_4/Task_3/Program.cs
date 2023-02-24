int[] FillArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i<n; i++)
    {
        arr[i] = rnd.Next(1,10);

    }

    return arr;
    
}

Console.Clear();

Console.WriteLine("Задача 27\nТребуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(7);
int i = 0;

foreach (int element in array)
{
    if(element == n)
        i++;
}
Console.WriteLine($"[{string.Join(", ", array)}] \nЧисло {n} встречается {i} раз(а).");
