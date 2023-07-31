int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");

}
int[] GetProductPairNumber(int[] arr)
{
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] product = new int[size];

    for (int i = 0; i < size; i++)
    {
        int prod = arr[i] * arr[arr.Length - i - 1];
        product[i] = prod;
    }
    if (arr.Length % 2 != 0) product[size - 1] = arr[arr.Length / 2];
    return product;
}

int[] array = CreateArrayRndInt(5, 0, 9);
PrintArray(array);
int[] productPair = GetProductPairNumber(array);
PrintArray(productPair);

