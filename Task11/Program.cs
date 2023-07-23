int number = new Random().Next (100, 1000);
Console. WriteLine($"Случайное трехзначное число -> {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int resultDigit = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Ответ: {resultDigit}");

int result = RemoveSecondDigit(number);
Console.WriteLine($"Ответ: {result}");

int RemoveSecondDigit (int num)
{
int firstDigit = num / 100;
int thirdDigit = num % 10;
int resultDigit = firstDigit * 10 + thirdDigit;
return resultDigit;
}