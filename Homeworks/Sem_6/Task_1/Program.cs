Console.Clear();

Console.WriteLine("Задача 41\nПользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

Console.Write("Укажите количество чисел на ввод: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.WriteLine("Начинайте ввод чисел: ");

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int m =0;
foreach (int element in array)
{
    if(element > 0)
        m++;
}

Console.WriteLine($"[{string.Join(", ", array)}] \nЧисло чисел больше нуля = {m}.");