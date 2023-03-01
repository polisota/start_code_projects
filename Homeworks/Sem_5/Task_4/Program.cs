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

Console.WriteLine("Cтатистика.");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(n, 1, 32);
int c = 0;

foreach (int element in array)
{
    if (element%2 == 1)
        c++;
}

int j = 0;
int m = 0;
int[] even = new int[array.Length - c];
int[] odd = new int[c]; //nechet

for (int i = 0; i<array.Length; i++)
{
    

    if (array[i]%2 == 0)
    {
        even[j] = array[i];
        j++;
    }
    else
    {
        odd[m] = array[i];
        m++;
    }        
}

Console.WriteLine($"Все дни: [{string.Join(", ", array)}]");
Console.WriteLine($"Нечетные: [{string.Join(", ", odd)}]");
Console.WriteLine($"Четные: [{string.Join(", ", even)}]");

if (m>j)
    Console.WriteLine("Нет");
else
    Console.WriteLine("Да");
