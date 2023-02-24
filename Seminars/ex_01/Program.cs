Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n > m)
//     Console.WriteLine(n);
// else if (n < m)
//     Console.WriteLine(m);
// else
//     Console.WriteLine("=");

// Array

int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
int begin = 10, end = 20;

for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);

foreach (double element in array)
{
    Console.WriteLine(element);
}

Console.WriteLine($"[{string.Join(", ", array)}]");