int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int [,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next (min, max + 1);
        }
        
    }
    return matrix;
}
void PrintMatrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i,j], 4} ");
        }
        Console.WriteLine("|");
    }
    
}

int SumLine(int[,] matrix, int i)
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
}

void FindMinSum(int[,] matrix)
{
    int rowMinSum = 0;
    int minSum = SumLine(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSum = SumLine(matrix, i);
        if (minSum > tempSum)
        {
            minSum = tempSum;
            rowMinSum = i;
        }
    }

    Console.WriteLine($"Наименьшая сумма элементов в строке -> {rowMinSum + 1}");
}
int [,] array2d = CreateMatrixRndInt(3,4,1, 9);
PrintMatrix(array2d);
Console.WriteLine();
FindMinSum(array2d);
