int PositiveNumbers(int[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) {j++;}
    }
    return j;
}

int[] CreateArray(int numbers)
{
    int[] arr = new int[numbers];
    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива : ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int InputCountArray(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numbers = InputCountArray("Введите количество элементов массива: ");
int[] arr = CreateArray(numbers);
Console.WriteLine($"Массив: [{String.Join(", " , arr)}]");
Console.WriteLine($"Колличество положительных чисел в массиве: {PositiveNumbers(arr)}");