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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }



}


int SumElementsDiagonal(int[,] matrix)

{
    int sum = 0;
    // int size = matrix.GetLength(0);
    // if (size > matrix.GetLength(1)) size = matrix.GetLength(1);

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) // должны проходиться по меньшей стороне из условии задачи
    {
        // for (int j = 0; j < matrix.GetLength(1); j++)
        // {
        // if 
        sum += matrix[i, i];
        // }
    }
    return sum;
}



int[,] array2d = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine($"Сумма элиментов = {SumElementsDiagonal(array2d)}");
