Console.Clear();

Console.Write("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());

double s = ((x1-x3)*(y2-y3)-(x2-x3)*(y1-y3))/2;

Console.WriteLine($"Площадь треугольника: {s}");