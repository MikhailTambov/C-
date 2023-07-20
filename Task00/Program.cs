Console.WriteLine("Введите целое число: "); 
int number = Convert.ToInt32(Console.ReadLine()); //преобразование строки в число
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}"); // или так "Квадрат числа = " + square