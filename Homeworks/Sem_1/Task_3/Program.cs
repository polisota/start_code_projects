Console.Clear();

Console.WriteLine("Задание№3.\nНапишите программу, которая на вход принимает число и выдаёт, является ли число чётным.");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 1)
    Console.WriteLine("Число нечетное.");
else
    Console.WriteLine("Число четное.");