Console.Write("Введите число :");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите степень числа :");
int numberB = Convert.ToInt32(Console.ReadLine());
ToDegree(numberA, numberB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}
