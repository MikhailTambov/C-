Console.WriteLine("Введите номер четверти");
string quarter =Console.ReadLine();

string coordinatesRange = GetCoordinates(quarter);
Console.WriteLine(coordinatesRange == null ? "Ошибка ввода": coordinatesRange);

string GetCoordinates (string quarterNumber)
{
    if (quarter == "1") return "x > 0,y > 0";
    if (quarter == "2") return "x < 0,y > 0";
    if (quarter == "3") return "x < 0,y < 0";
    if (quarter == "4") return "x > 0,y < 0";  
    return null;
}