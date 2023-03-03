Console.Clear();
//Задача 46: Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
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

//Задача 48: Задайте двумерный массив размера m на п, каждый элемент в массиве находится
//по формуле: Аmn = m+n. Выведите полученный массив на экран.

void InputMatrixAmn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i+j;
    }
}

Console.Write("Введите размер массива: ");
int[] sizeAmn = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixAmn = new int[sizeAmn[0], sizeAmn[1]];
InputMatrixAmn(matrixAmn);
PrintMatrix(matrixAmn);

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
Console.Write("Введите размер массива: ");
int[] size49 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix49 = new int[size49[0], size49[1]];
InputMatrixAmn(matrix49);
PrintMatrix(matrix49);
Console.WriteLine();
for (int i = 0; i < matrix49.GetLength(0); i++)
{
    for (int j = 0; j < matrix49.GetLength(1); j++)
    {
        if (i % 2 == 1 && j % 2 == 1)
        {
            matrix49[i, j] *= matrix49[i, j];
        }
    }
}
PrintMatrix(matrix49);

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Console.Write("Введите размер массива: ");
int[] size51 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix51 = new int[size51[0], size51[1]];
InputMatrixAmn(matrix51);
PrintMatrix(matrix51);
int sum = 0;
for (int i = 0; i < matrix51.GetLength(0); i++)
{
    for (int j = 0; j < matrix51.GetLength(1); j++)
    {
        if (i == j)
        {
            sum += matrix51[i, j];
        }
    }
}
Console.WriteLine($"Сумма главной диагонали массива = {sum}");