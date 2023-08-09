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
int[,] MatrixMultiply(int[,] matrix, int[,] matrix2)
{
    if(matrix.GetLength(1) != matrix2.GetLength(0))
    {
        int[,] matrix4 = new int[0,0];
        Console.WriteLine($"Перемножение невозможно");
        return matrix4;
    }
    int[,] matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrix3[i,j] += matrix[i,k] * matrix2[k,j];
            }
        }
    }
    return matrix3;

}
int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк в первом массиве: ");
int columns = GetInput("Введите количество столбцов в первом массиве: ");
int[,] array2d = CreateMatrixRndInt(rows, columns, 1, 9);
Console.WriteLine("Первый массив:");
PrintMatrix(array2d);
Console.WriteLine();
int rows2 = GetInput("Введите количество строк во втором массиве: ");
int columns2 = GetInput("Введите количество столбцов во втором массиве: ");
int[,] array2d2 = CreateMatrixRndInt(rows2, columns2, 1, 9);
Console.WriteLine("Второй массив:");
PrintMatrix(array2d2);
Console.WriteLine("Произведение матриц:");
int [,] array2d3 = MatrixMultiply(array2d,array2d2);
PrintMatrix(array2d3);
