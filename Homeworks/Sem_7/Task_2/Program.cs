Console.Clear();

Console.WriteLine("Задача 50\nНапишите программу, которая на вход принимает позиции элемента в двумерном массиве," + 
"и возвращает значение этого элемент или же указание, что такого элемента нет.");

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

void CheckMatrixElement(int[] position, int[,] matrix)
{
    for (int i = 0; i < position.Length; i++)
        position[i] -= 1;

    if (position[0] > matrix.GetLength(0) || position[1] > matrix.GetLength(1))
        Console.WriteLine("Нет такого элемента");
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == position[0])
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == position[1])
                        Console.WriteLine($"Искомый элемент = {matrix[i, j]}");
                }
            }
        }
    }

}

Console.Write("Введите номер элемента массива: ");
int[] position = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[5, 5];
InputMatrix(matrix);
PrintMatrix(matrix);
CheckMatrixElement(position, matrix);
