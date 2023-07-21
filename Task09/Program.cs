int number = new Random().Next(10, 100);
Console.WriteLine ($"Случайное число от 10 до 99 -> {number}");
// int firstDigit = number / 10; //отбрасывается дробная часть от реззультата деления
// int secondDigit = number % 10; //остаток деления на 10
// if (firstDigit > secondDigit) Console.WriteLine($"Максимальная цифра числа {firstDigit}");
// else Console.WriteLine($"Максимальная цифра числа {secondDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Максимальная цифра числа - {maxDigit}");
int maxDigit1 = MaxDigit(56);
Console.WriteLine($"Максимальная цифра числа - {maxDigit1}");
int maxDigit2 = MaxDigit(89);
Console.WriteLine($"Максимальная цифра числа - {maxDigit2}");


int MaxDigit (int num)  
{
    int firstDigit = num / 10; //отбрасывается дробная часть от реззультата деления
    int secondDigit = num % 10; //остаток деления на 10
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}