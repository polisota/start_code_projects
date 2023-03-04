Console.Clear();

Console.WriteLine("Транспонирование - 4\nЗадана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.");

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

void HorizontalReverse(int[,] matrix)
{
    int n = matrix.GetLength(0)-1;

    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        int temp = 0;

        if (n >= 0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[n, j];
                matrix[n, j] = temp;
            }
        }
        n--;
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
HorizontalReverse(matrix);
PrintMatrix(matrix);
