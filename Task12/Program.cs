Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int IsMultiplicity (int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}

int reminder = IsMultiplicity(firstNum, secondNum);
// if (reminder == 0) Console.Write("кратно");
// else Console.Write($"не кратно, остаток деления {reminder}");

Console.Write(reminder == 0 ? "кратно" : $"не кратно, остаток {reminder}");