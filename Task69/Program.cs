Console.WriteLine("Введите первое натуральное число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int numberB = Convert.ToInt32(Console.ReadLine());

int pow = PowNumber(numberA, numberB);
Console.WriteLine(pow);

int PowNumber(int number1, int number2) // 3 /5
{
    if (number2 == 0) return 1; // 3 - 5, 3-4, 3-3, 3-2, 3-1, (3-0)
    return number1 * PowNumber(number1, number2 - 1); //3 3 3 3 3 1 = 243
}