/*
    Задание №3: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
*/
//
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
            Console.Write("Не выходной. ):");
            break;
        case 6:
        case 7:
            Console.Write("ВЫХОДНОЙ!");
            break;
        default:
            Console.Write("Вас просили ввести цифру соответсвующую дню недели.");
            break;
    }
}
GetMEDayOff();

