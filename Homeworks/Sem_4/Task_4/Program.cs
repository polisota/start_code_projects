//Дана последовательность из N целых чисел и число K. Необходимо сдвинуть
//всю последовательность (сдвиг - циклический) на |K| элементов вправо,
//если K – положительное и влево, если отрицательное.

int[] FillArray(int n, int k)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i<n; i++)
    {
        arr[i] = rnd.Next(1,k);

    }

    return arr;
    
}

// void Reverse(int[] array, int n)
// {
//     if (n<=1)
//     {
//         return;
//     }
//     else
//     {
//         int i = 0, j = n-1;
//         while (i<j)
//         {
//             int temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//             i++;
//             j--;
//         }
//     }
// }

Console.Clear();

Console.WriteLine("Cуперсдвиг.");

Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(n, 10);
int[] arr = new int[n];
Console.Write("Введите число для сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", array)}]");

k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        arr[i] = array[n - k + i];
    for (int i = 0; i < n - k; i++)
        arr[k + i] = array[i];    
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}
else
{
    for (int i = 0; i < Math.Abs(k); i++)
        arr[n - Math.Abs(k) + i] = array[i];
    for (int i = 0; i < n - Math.Abs(k); i++)
        arr[i] = array[Math.Abs(k) + i]; 
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}

