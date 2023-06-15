// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите номер дня недели: ");
int.TryParse(Console.ReadLine(), out int numDay);
Day day = (Day)numDay;

switch (day)
{
    case Day.Понедельник:
    case Day.Вторник:
    case Day.Среда:
    case Day.Четверг:
    case Day.Пятница:
        Console.Write($"{day}, Не выходной. ):");
        break;
    case Day.Суббота:
    case Day.Воскресенье:
        Console.Write($"{day}, ВЫХОДНОЙ!");
        break;
    default:
        Console.Write("Вас просили ввести цифру соответсвующую дню недели.");
        break;
}

enum Day
{
    Понедельник = 1,
    Вторник = 2,
    Среда = 3,
    Четверг = 4,
    Пятница = 5,
    Суббота = 6,
    Воскресенье = 7
}
