int max = 0;

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine($"max = {max}");
