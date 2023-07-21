int number = new Random().Next(10, 100);
Console.WriteLine ($"Случайное число от 10 до 99 -> {number}");
int firstDigit = number / 10; //отбрасывается дробная часть от реззультата деления
int secondDigit = number % 10; //остаток деления на 10
if (firstDigit > secondDigit) Console.WriteLine($"Максимальная цифра числа {firstDigit}");
else Console.WriteLine($"Максимальная цифра числа {secondDigit}");

