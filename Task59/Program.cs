// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] MinimumElementMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                row = i;
                column = j;
            }
        }        
    }
    return new int[]{row, column};
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] RemoveRowColumnMinElement(int[,] matrix, int[] array)
{
    int rowDel = array[0];
    int columnDel = array[1];
    int [,] newMatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    for (int i = 0; i < length; i++)
    {
        
    }
}
int[,] array2D = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] minElementMatrix = MinimumElementMatrix(array2D);
PrintArray(minElementMatrix);

// int[,] CreateNewMatrix(int[,] matr, int[] ind)
// {
//     int[,] newMatr = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
//     int row = 0;
//     for (int i = 0; i < newMatr.GetLength(0); i++)
//     {
//         if (row == ind[0]) row++; 
//         int column = 0;
//         for (int j = 0; j < newMatr.GetLength(1); j++)
//         {
//             if (column == ind[1]) column++; 
//             newMatr[i, j] = matr[row,column];
//             column++;
//         }
//         row++;
//     }
//     return newMatr;
// }

// int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, depth]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1);
//             }
            
//         }
//     }
//     return matrix;
// }

