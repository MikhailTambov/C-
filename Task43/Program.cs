void FindPoint(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1)/(k1-k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

double InputPoint(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = GetInput("Введите значение b1: ");
double b2 = GetInput("Введите значение b2: ");
double k1 = GetInput("Введите значение k1: ");
double k2 = GetInput("Введите значение k2: ");
FindPoint(b1, b2, k1, k2);