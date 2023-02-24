Console.Clear();

Console.WriteLine("Задача 25\nНапишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = 1;

for (int i = 1; i<=b; i++)
{
    res *=a;
}

Console.Write($"Результат: {res}");