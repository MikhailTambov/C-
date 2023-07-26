Console.WriteLine("Введите целое положительное число") ;
int number = Convert.ToInt32(Console. ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел в диапозоне от 1 до {number} = {sumNumbers}");


int SumNumbers(int num)
{   
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i; // sum = sum + 1;
    }
    return sum;
}
