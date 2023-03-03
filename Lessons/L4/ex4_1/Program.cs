﻿Console.Clear();
// String.Empty
// table[0,0] table[0,1] table[0,2]	table[0,4]
// table[l,0] table[1,1] table[l,2]	table[l,4]

string[,] table = new string[2, 5];

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) //for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }        
    }
}

int [,] matrix = new int[3, 4];
PrintArray (matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray (matrix);