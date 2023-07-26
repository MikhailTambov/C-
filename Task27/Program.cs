Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

int len = NumberLen(number);
SumNumbers(number, len);

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Cумма цифр: {sum}");
}