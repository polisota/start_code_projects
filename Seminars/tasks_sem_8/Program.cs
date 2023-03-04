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
Console.Clear();
//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
void ReplaceRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
ReplaceRow(matrix);
Console.WriteLine("Конечный массив:");
PrintMatrix(matrix);

//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void ReplaceRowT(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

Console.Write("Введите размер массива: ");
int[] size55 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
while (size55[0] != size55[1])
{
    Console.Write("Вы ошиблись!\nВведите размер массива: ");
    size55 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix55 = new int[size55[0], size55[1]];
InputMatrix(matrix55);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix55);
ReplaceRowT(matrix55);
Console.WriteLine("Конечный массив:");
PrintMatrix(matrix55);


//57. Составить частотный словарь элементов двумерного массива. Частотный словарь
//содержит информацию о том, сколько раз встречается элемент входных данных.

bool checkElement(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return false;
    }
    return true;
}

int inputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            if (checkElement(array, matrix[i, j]))
            {
                array[k] = matrix[i, j];
                k++;
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return k;
}


void CheckElement(int[,] matrix, int[] array, int countArray)
{
    for (int k = 0; k < countArray; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {       
                if (array[k] == matrix[i, j])
                    count++;
            }
        }
        Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
    }

}

Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix57 = new int[coord[0], coord[1]];
int[] array = new int[coord[0] * coord[1]];
Console.WriteLine("Начальный массив: ");
int countArray = inputMatrix(matrix57, array);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}]");
CheckElement(matrix57, array, countArray);

//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.

void PrintMatrix59(int[,] matrix, int row, int col)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i != row && j != col)
                Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int[] size59 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix59 = new int[size59[0], size59[1]];
InputMatrix(matrix59);
PrintMatrix(matrix59);
Console.WriteLine();
int min = matrix59[0,0];
int row = 0;
int col = 0;
for (int i = 0; i < matrix59.GetLength(0); i++)
{
    for (int j = 0; j < matrix59.GetLength(1); j++)
    {
        if (matrix59[i,j]<min)
        {
            min = matrix59[i,j];
            row = i;
            col = j;
        }
    }
        
}
PrintMatrix59(matrix59, row, col);

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// void SwapFirstLastString(int[,] matrix)
// {
//     int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < minValue)
//             {
//                 minValue = matrix[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }
//     Console.WriteLine($"Минимум {minValue} на позиции({minRow + 1}, {minColumn + 1})");
//     Console.WriteLine();
//     Console.WriteLine("Конечный массив");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i != minRow)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j != minColumn)
//                     Console.Write($"{matrix[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// Console.WriteLine("Начальный массив");
// InputMatrix(matrix);
// SwapFirstLastString(matrix);
