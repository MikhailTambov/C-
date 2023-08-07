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
int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArif(int[,] matrix)
{
    Console.Write($"Среднее арифметическое столбца: ");
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
        }
        Console.Write($" {Math.Round((sum/matrix.GetLength(0)),1)} ");
        sum = 0;
    }
}

int rows = GetInput("Введите количество строк в массиве: ");
int columns = GetInput("Введите количество столбцов в массиве: ");
Console.WriteLine();
int[,] matrix = CreateMatrixRndInt(rows, columns, -100, 100);
PrintMatrix(matrix);
Console.WriteLine();
PrintArif(matrix); 