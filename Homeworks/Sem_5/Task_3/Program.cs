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

Console.WriteLine("Задача 38\nЗадайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.");

int[] array = FillArray(10, -100, 101);

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];

}
Console.WriteLine($"[{string.Join(", ", array)}] \n({max}) - ({min}) = {max - min}.");
