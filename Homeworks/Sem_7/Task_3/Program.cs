Console.Clear();

Console.WriteLine("Задача 52\nЗадайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double sum = 0;

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum += matrix[j, i];
        Console.WriteLine(sum);

    }
    Console.WriteLine(i + " " + Math.Round((sum / matrix.GetLength(0)), 2));
}
