/*
    Задание №3: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
*/
//Вариант первый по проще.
void GetMEDayOff()
{
    Console.WriteLine("Введите номер дня недели: ");
    int.TryParse(Console.ReadLine(), out int numDay);

    switch (numDay)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Не выходной. ):");
            break;
        case 6:
        case 7:
            Console.WriteLine("ВЫХОДНОЙ!");
            break;
        default:
            Console.WriteLine("Вас просили ввести цифру соответсвующую дню недели.");
            break;
    }
}

//Вариант два. По круче. Бессмысленно и беспощадно, но по круче.
void GetMeDay()
{
    Console.WriteLine("Введите номер дня недели: ");
    int.TryParse(Console.ReadLine(), out int numDay);
    Day day = (Day)numDay;
    GetMeListDay(day);
}
void GetMeListDay(Day day)
{
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
}

//Здесь вызов обоих методов.
//1-й
GetMEDayOff();
//2-й
GetMeDay();
//Енум живёт свой отдельной жизнью и в методы вписываться не хочет. 
//Полагаю, его по идеи нужно в отдельный класс кидывать.
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

