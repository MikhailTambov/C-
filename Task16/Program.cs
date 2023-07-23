Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int div = number % 2;

if(div == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}