Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] array = CreateArrayRndInt(size, 1, 1000);
PrintArray(array);


for (int arr = 0; arr < array.Length; arr += 2)
    sum = sum + array[arr];

Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

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


void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i < numbers.Length - 1) Console.Write($"{numbers[i]}, ");
        else Console.Write($"{numbers[i]}");
    }
    Console.WriteLine("]");

}

