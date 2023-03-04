Console.Clear();
//Задача 63: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N.

string rec(int n)
{
    if (n == 1)
        return "1";
    return rec(n - 1) + $", {n}";
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));

//Задача 65: Задайте значения М и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от М до N.

string rec1(int a, int b)
{
    if (b == a)
        return $"{a}";
    return rec1(a, b - 1) + $", {b}";
}

Console.Write("Введите 1-ое число: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec1(m1, n1));
//Задача 67: Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр.
int rec2(int a)
{
    if (a < 10)
        return a;
    return rec2(a / 10) + a % 10;
}

Console.Write("Введите число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec2(n2));

//Задача 69: Напишите программу, которая на вход принимает два числа А и В, и
//возводит число А в целую степень В с помощью рекурсии.

int stepen(int a, int b)
{
    if (b == 0)
        return 1;
    return stepen(a, b - 1) * a;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(stepen(a, b));