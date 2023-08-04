Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());


// int DecToBinnary(int number)
// {
//     int result = 0;
//     int decimalBase = 1;
//     while (number > 0)
//     {
//         result += number % 2 * decimalBase;
//         number /= 2;
//         decimalBase *= 10;
//     }
//     return result;
// }

// int bin = DecToBinnary(number);
// Console.WriteLine(bin);


string DecToBinnary(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
        
    }
    return result;
}

Console.WriteLine(DecToBinnary(number));
