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

int [] FindPosOfMin (int[,] matrix)
{
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minRow, minCol])
            {
                minRow = i;
                minCol = j;
            }
        }
    }
    return new int [] { minRow, minCol };
}

int [,] RemoveCrossMinElement (int[,] matrix, int row, int column)
{
    int [,] result = new int [matrix.GetLength(0) -1, matrix.GetLength(1) - 1 ];
    int m = 0;
    int n = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (m == row) m++;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (n == column) n++;
            result [i,j] = matrix [m,n];
            n++;
        }
        n = 0;
        m++;
    }
    return result;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

Console.WriteLine();
int [] pos = FindPosOfMin(array2d);
int [,] res = RemoveCrossMinElement(array2d, pos[0], pos[1]);
PrintMatrix(res);
