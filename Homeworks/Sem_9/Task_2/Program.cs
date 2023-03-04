Console.Clear();

Console.WriteLine("Задача 66\nЗадайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");

int rec(int m, int n, int sum)
{
    if (m > n)
        return sum;
    sum += m++;
    return rec(m, n, sum);
}

Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n, 0));