Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers (int num)
{
    if (num == 0) return;
     Console.Write($"{num} ");
    NaturalNumbers(num -1);
} 