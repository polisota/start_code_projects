Console.Clear();

Console.WriteLine("Задача 19\nНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (Math.Abs(n) < 10000 || Math.Abs(n) > 99999)
{
    Console.Write("Ошибка!\nВведите ПЯТИЗНАЧНОЕ число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int nNew = 0;
int nTest = Math.Abs(n);
int d;

while (nTest>0)
{
    d = nTest%10;
    nTest /= 10;
    nNew = nNew * 10 + d;
}

if (nNew == Math.Abs(n))
{
    Console.Write("Введенное число является палиндромом");
}
else
{
    Console.Write("Введенное число не является палиндромом");
}
