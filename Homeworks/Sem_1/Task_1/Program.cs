Console.Clear();

Console.WriteLine("Задание№1.\nНапишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.Write($"Первое число больше: {a}, меньшее: {b}.");
else if (a < b)
    Console.Write($"Второе число больше: {b}, меньшее: {a}.");
else
    Console.Write("Числа равны.");

