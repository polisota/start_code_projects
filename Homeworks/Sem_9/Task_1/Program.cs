Console.Clear();

Console.WriteLine("Задача 64\nЗадайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");

string rec(int n)
{
    if (n == 1)
        return "1";
    return $"{n}, " + rec(n - 1);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));