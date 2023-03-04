Console.Clear();

Console.WriteLine("Задача 58\nЗадайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21);
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

int[,] multiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int [,] res = matrix1;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            res[i,j] = matrix1[i,j] * matrix2[i,j];
    }
    return res;
}

Console.Write("Введите размер массивов: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = new int[size[0], size[1]];
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(multiplyMatrix(matrix1, matrix2));