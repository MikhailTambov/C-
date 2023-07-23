
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool num = IsSquareTwoNumbers(firstNumber, secondNumber);
Console.WriteLine(num ? "Да": "Нет"); 

bool IsSquareTwoNumbers (int firstNum, int secondNum)
{
    return  firstNum == secondNum * secondNum || secondNum == firstNum * firstNum;
}