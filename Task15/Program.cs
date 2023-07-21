Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingDayWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день выходной -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это вообще не день недели");
  }
  else Console.WriteLine("Этот день не выходной -> нет");
}

CheckingDayWeek(dayNumber);