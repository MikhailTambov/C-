void PrintRequestElement(int[,] matrix, int requestElementRow, int requestElementColumn)
{
    if (requestElementRow > matrix.GetLength(0) | requestElementColumn > matrix.GetLength(1)) 
    {Console.WriteLine($"Такого элемента нет");}
    else {Console.WriteLine($"{matrix[requestElementRow-1,requestElementColumn-1]}");}
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

int rows = GetInput("Введите количество строк в массиве: ");
int columns = GetInput("Введите количество столбцов в массиве: ");
Console.WriteLine();
int[,] matrix = CreateMatrixRndInt(rows, columns, -100, 100);
PrintMatrix(matrix);
Console.WriteLine();
int requestElementRow = GetInput("Введите номер строки, на которой располагается требуемый элемент: ");
int requestElementColumn = GetInput("Введите номер столбца, на которой располагается требуемый элемент: ");
PrintRequestElement(matrix, requestElementRow, requestElementColumn);