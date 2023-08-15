Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Введите натуральное число");
    return;
}
NaturalNumbersRange(number1, number2);

void NaturalNumbersRange(int m, int n)
{
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumbersRange(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumbersRange(m + 1, n);
    }
    else Console.Write($"{m}");
}