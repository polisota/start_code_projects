Console.Clear();

Console.WriteLine("Задача 62\nНапишите программу, которая заполнит спирально массив 4 на 4.");

void InputMatrix(int[,] matrix)
{
    int count = 1;

    int h = 0;
    int v = 0;
    int size = matrix.GetLength(0);

    while (size > 0)
    {
        for (int i = v; i <= v + size - 1; i++)
            matrix[h, i] = count++;

        for (int j = h + 1; j <= h + size - 1; j++)
            matrix[j, v + size - 1] = count++;

        for (int i = v + size - 2; i >= v; i--)
            matrix[h + size - 1, i] = count++;

        for (int i = h + size - 2; i >= h + 1; i--)
            matrix[i, v] = count++;

        h ++;
        v ++;
        size -= 2;
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
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
InputMatrix(matrix);
PrintMatrix(matrix);