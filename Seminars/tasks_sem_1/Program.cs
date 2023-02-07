Console.Clear();
Console.WriteLine("Задание№1.\nНапишите программу, которая на вход принимает число и выдает его квадрат.");
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Квадрат введенного числа = {n*n}");

Console.WriteLine("\nЗадание№2.\nНапишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.");
Console.Write("Введите первое число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToInt32(Console.ReadLine());
if (a/b == b)
    Console.Write("Первое введенное число является квадратом второго!");
else
{
    Console.Write("Первое число НЕ является квадратом второго...");
}

Console.WriteLine("\nЗадание№3.\nНапишите программу, которая будет выдавать название дня недели по заданному номеру.");
Console.Write("Введите число: ");
int v = Convert.ToInt32(Console.ReadLine());
while (v < 1 || v > 7)
{
    Console.Write("Ошибка!\nВведите число от 1 до 7: ");
    v = Convert.ToInt32(Console.ReadLine());
}
if (v == 1)
    Console.WriteLine("Понедельник");
else if (v == 2)
    Console.WriteLine("Вторник");
else if (v == 3)
    Console.WriteLine("Среда");
else if (v == 4)
    Console.WriteLine("Четверг");
else if (v == 5)
    Console.WriteLine("Пятница");
else if (v == 6)
    Console.WriteLine("Суббота");
else
    Console.WriteLine("Воскресенье");

Console.WriteLine("\nЗадание№4.\nНапишите программу, которая на вход принимает одно число(N), а на выходе показывает все целые числа в промежутке от -N до N.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numM;
int numS;
if (num>0)
{
    numS = num*2 + 1;
    numM = 0-num;
}
else
{
    numS = 0-(num*2 + 1);
    numM = num;
}
int count = 0;
while(count < numS)
{   
    Console.Write($"{numM} ");
    numM += 1;
    count++;
} // Увидела семинарское решение) Гораздо проще, конечно, но я учла отрицательные числа))


/*Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()), count = (-1) * num;
while (count <= num)
{
    Console.Write($"{count} ");
    count++;
}*/

Console.WriteLine("\n\nЗадание№5.\nНапишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1 % 10);