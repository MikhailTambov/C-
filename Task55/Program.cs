﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }



}

void RepleceRowsColums(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }

    }
}

bool CheckSquareMatrix(int[,] matrix)
{
    return matrix.GetLength (0) == matrix.GetLength (1);
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
if (!CheckSquareMatrix(array2d));
    {
        Console.WriteLine("Матрица не квадратная, не возможно заменить столбы на строки");
        return;
    }

Console.WriteLine();
RepleceRowsColums(array2d);
PrintMatrix(array2d);