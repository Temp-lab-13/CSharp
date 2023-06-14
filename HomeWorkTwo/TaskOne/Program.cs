/*
    Задание №1: 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
*/
//Вариант один.

void ReqvestAndExemUserNum()
{
    Console.Write("Введите трёхзначное число: ");
    bool trueNumber = int.TryParse(Console.ReadLine(), out int numberXXX);
    GetTwoNumber(numberXXX, trueNumber);

}
void GetTwoNumber(int numberXXX, bool trueNumber)
{
    if (trueNumber == true && numberXXX > 99 && numberXXX < 1000)
    {
        numberXXX = (numberXXX / 10) % 10;
        Console.WriteLine($"Второй символ указанного числа равен: {numberXXX}\n");
    }
    else
    {
        Console.WriteLine($"Введено не корректное число.\n");
    }
}

//Вариант два.

int ExemAndGetTwoNumber()
{
    Console.Write("Введите трёхзначное число: ");
    bool trueNumber = int.TryParse(Console.ReadLine(), out int numberXXX);
    return GetTwoUserNumber(numberXXX, trueNumber);
}
int GetTwoUserNumber(int numberXXX, bool trueNumber)
{
    if (trueNumber == true && numberXXX > 99 && numberXXX < 1000)
    {
        numberXXX = (numberXXX / 10) % 10;
        Console.Write($"Второй символ указанного числа равен: ");
        return numberXXX;
    }
    else
    {
        Console.Write("Введено не корректное число или символы: ");
        return numberXXX;
    }
}
//Здесь вызовы методов.
ReqvestAndExemUserNum();
int resalt = ExemAndGetTwoNumber();
Console.Write(resalt);
