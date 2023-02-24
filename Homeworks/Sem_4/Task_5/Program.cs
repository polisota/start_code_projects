Console.Clear();

Console.WriteLine("Гипотеза Гольдбаха");

Console.Write("Введите четное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;

for (i = 2; i <= n / 2; i++)
{
    countDel = 0;
    for (j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
            countDel++;
    }

    if (countDel == 0)
    {
        countDel = 0;
        m = n - i;
        for (k = 2; k <= (m + 1) / 2; k++)
        {
            if (m % k == 0)
                countDel++;
        }
        if (countDel == 0)
        {
            Console.WriteLine($"{n} = {i} + {m}");
            return;
        }
    }
}