// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine());
// int factorial = 1;
// for (int i = 1; i <= num; i++)
// {
//     factorial *= i;
//     if (i == num)
//     {
//         Console.Write("{0}", i);
//     }
//     else
//     {
//         Console.Write("{0} * ", i);
//     }
// }
// Console.Write(" = {0}", factorial);


Console.WriteLine("Введите целое положительное число") ;
int number = Convert.ToInt32(Console. ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел в диапозоне от 1 до {number} = {factorial}");


int Factorial(int num)
{   
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // try catch
        {
        fact *= i; // fact +1
        }
    }
    return fact;
}

