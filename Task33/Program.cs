﻿int[] CreateArrayRndInt(int size, int min, int max)
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

bool FindNumberInArray (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        return true;
    }
    return false;
}
Console.WriteLine();

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
bool isExistNumner = FindNumberInArray(array, 3);
Console.WriteLine(isExistNumner? "Yes" : "No");

