Console.Write("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n< 0 || m < 0)
{
    Console.WriteLine("Введите натуральное число");
    return;
}
Console.WriteLine(FindSum(m, n));
int FindSum(int numM, int numN)
{
    if (numN == numM) return numN;
    if (numM > numN) return numN + FindSum(numM, numN + 1);
    return numM + FindSum(numM + 1, numN);
}
