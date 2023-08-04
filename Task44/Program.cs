Console.WriteLine("Размер массива не меньше 2");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 2)
{
    Console.WriteLine("некоректный ввод");
    return;
}

int[] CreateArrayFib(int size)
{
    int[] arr = new int[size];
    arr[1] = 1;



    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
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
PrintArray(CreateArrayFib(size));