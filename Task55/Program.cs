﻿// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}
int[,] ReplaceRowsColumns(int[,] matrix)
{
    int[,] matr = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = matrix[j,i];
        }
    }
    return matr;
}

int[,] array2D = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
if(array2D.GetLength(0) == array2D.GetLength(1))
{
int[,] newMatrix = ReplaceRowsColumns(array2D);
PrintMatrix(newMatrix);
}
else
{
    Console.WriteLine("Замена невозможна");
}
// void ReplaceRowsColumns(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0)-1; i++) 
//     {   
//         for (int j = i+1; j < matr.GetLength(1); j++)
//         {
//             // int temp = matr[i,j];
//             // matr[i,j] = matr[j,i];
//             // matr[j,i] = temp;
//             (matr[i,j], matr[j,i]) = (matr[j,i], matr[i,j]);            
//         }
//     }
// }



// Console.Write("Введите количество строк массива: m=");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: n=");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrixRndInt(m, n, -9, 9);
// PrintMatrix(matrix);
// Console.WriteLine();
// if (m==n) 
// {
// ReplaceRowsColumns(matrix);
// PrintMatrix(matrix);
// }
// else Console.WriteLine("Массив не квадратный, замена невозможна.");
