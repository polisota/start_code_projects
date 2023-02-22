Console.Clear();

Console.WriteLine("Задача 21\nНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + + Math.Pow((z2-z1), 2));

Console.Write($"Расстояние между точками = {Math.Abs(Math.Round(res, 3))} ");
