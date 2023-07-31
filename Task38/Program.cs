Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] arrDouble = CreateArrayRndDouble(size, 1, 100);
PrintArrayDouble(arrDouble);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int arr = 0; arr < arrDouble.Length; arr++)
{
    if (arrDouble[arr] > max)
    {
        max = arrDouble[arr];
    }
    if (arrDouble[arr] < min)
    {
        min = arrDouble[arr];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, int round = 1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }
    Console.WriteLine("]");

}