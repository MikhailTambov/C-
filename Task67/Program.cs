// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialRec(10)); // 3628800


int SumDigit(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumDigit(number / 10);
}
Console.WriteLine(SumDigit(453));