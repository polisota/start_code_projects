Console.Clear();

Console.WriteLine("Задание№1.\nНапишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.Write("Ошибка!\nВведите число от 100 до 999: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int n3 = n % 10;
int nNew = (n - n3)/10;
Console.WriteLine(nNew % 10);