Console.WriteLine("Введите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    int counter = -number;
    while (counter <= number)
    {
        Console.Write(counter + " ");
        counter++;
    }
}