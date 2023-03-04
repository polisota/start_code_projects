Console.Clear();

Console.WriteLine("Задача 68\nНапишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int akk = A(m, n);
Console.WriteLine(akk);