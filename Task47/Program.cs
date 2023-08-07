double[,] CreateMatrixRndInt(int rows, int columns)
{
    double [,] matrix = new double[rows, columns];
    Random rnd = new Random();
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble()*10,1);
        }
        
    }
    return matrix;
}
void PrintMatrix(double [,] matrix)
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
int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int rows = GetInput("Введите количество строк: ");
int columns = GetInput("Введите количество столбцов: ");
double [,] array2d = CreateMatrixRndInt(3,4);
PrintMatrix(array2d);    