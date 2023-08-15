Console.Write("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n< 0 || m < 0)
{
    Console.WriteLine("Введите не отрицательное число");
    return;
}
Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0) return Akkerman(m-1,1);
    if (m > 0 && n > 0) return Akkerman(m-1, Akkerman(m,n-1));
    return -1;
}
