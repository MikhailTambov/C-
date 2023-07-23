Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool num = IsMultiplicity(number);
Console.WriteLine(num ? "Да": "Нет"); 

bool IsMultiplicity(int num)
{

    return num % 7 == 0 && num % 23 == 0;
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
// return false;
}
