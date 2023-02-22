Console.Clear();

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем Х!=0 и Y!=0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

while (x == 0 || y == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
}

if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");

//Задача №18. Напишите программу, которая по заданному номеру четверти, показывает
//диапазон возможных координат точек в этой четверти (х и у).
Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 4)
{
    Console.Write("Вы ошиблись!\nВведите номер четверти: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n == 1)
    Console.WriteLine("x > 0 | y > 0");
else if (n == 2)
    Console.WriteLine("x < 0 | y > 0");
else if (n == 3)
    Console.WriteLine("x < 0 | y < 0");
else
    Console.WriteLine("x > 0 | y < 0");

//Задача №21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 2D пространстве.
Console.Write("Введите координату X первого числа: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первого числа: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X второго числа: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второго числа: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y2-y1), 2));

Console.Write($"Расстояние между точками = {Math.Round(res, 3)} ");

//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу квадратов чисел от 1 до N.
Console.WriteLine("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<=a)
{
    Console.Write($"{Math.Pow(i, 2)} ");
    i ++;
}