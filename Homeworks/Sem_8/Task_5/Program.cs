Console.Clear();

Console.WriteLine("Задача 61\nВывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника");

Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
int n = Convert.ToInt32(Console.ReadLine());

int Factorial(int n)
{
    int m = 1;
    for (int i = 1; i <= n; i++)
        m *= i;
    return m;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= (n - i); j++)
        Console.Write(" ");
    for (int j = 0; j <= i; j++)
        Console.Write($" {Factorial(i) / (Factorial(j) * Factorial(i - j))}");
    Console.WriteLine();
}