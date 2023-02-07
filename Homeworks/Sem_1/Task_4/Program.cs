Console.Clear();

Console.WriteLine("Задание№4.\nНапишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
        Console.Write($"{count} ");        
    count++;
}
