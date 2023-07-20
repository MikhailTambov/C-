//получение последней цифры числа

Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1; // преобразование в положительное если отрицательное
}

if (number >= 100 && number <= 999) // проверка трехначности
{
    int lastDigit = number % 10; //остаток деления на 10  456%10 = 6
    Console.Write("Последняя цифра числа :" + lastDigit);
}
    else
    {
        Console.WriteLine("Ошибка ввода");
    }