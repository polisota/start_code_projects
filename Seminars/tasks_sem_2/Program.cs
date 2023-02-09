Console.Clear();
Console.WriteLine("Задание№1.\nНапишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.");
int n = new Random().Next(10, 100);
Console.WriteLine(n);	
int n1 = n / 10;	
int n2 = n % 10;
if (n1 > n2)
    Console.WriteLine(n1);	
else
    Console.WriteLine(n2);	

Console.WriteLine("Задание№2.\nНапишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.");
int m = new Random().Next(100, 1000);
Console.WriteLine(m);
int m1 = m / 100;
int m3 = m % 10;
Console.WriteLine(m1 * 10 + m3);

Console.WriteLine("Задание№3.\nНапишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.");
Console.Write("Введите первое число: ");
long a = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите второе число: ");
long b = Convert.ToInt64(Console.ReadLine());
if (a % b != 0)
    Console.WriteLine(a % b);
else
    Console.WriteLine("кратно"); 
    
Console.WriteLine("Задание№4.\nНапишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
Console.Write("Введите число: ");
int v = Convert.ToInt32(Console.ReadLine());
if (v % 161 == 0)
  Console.WriteLine("yes");
else
  Console.WriteLine("no");

Console.WriteLine("Задание№4.\nНапишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.");
Console.Write("Введите первое число: ");
double c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double d = Convert.ToInt32(Console.ReadLine());
c = Math.Abs(c);
d = Math.Abs(d);
if (c/d == d || d/c == c)
    Console.Write("Одно из чисел является квадратом другого.");
else
{
    Console.Write("Числа НЕ являются квадратами друг друга...");
}