/*
    Задание №2:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
*/
//Не вижу смысла всё сваливать в один метод. Это я пробовал в прошлом Task.
void ImputAndExamMumber()
{
    Console.Write("Введите число: ");
    bool trueNumber = int.TryParse(Console.ReadLine(), out int number);
    GetMeThreeNumber(number, trueNumber);
}

void GetMeThreeNumber(int number, bool trueNumber)
{
    if (number > 99 && trueNumber == true)
    {
        for (int i = 1000; i < number;)
        {
            number = number / 10;
        }
        number = number % 10;
        Console.WriteLine(number);
    }
    else if (trueNumber == true)
    {
        Console.WriteLine("Число меньше трёх.");
    }
    else
    {
        Console.WriteLine("Введены не корректные символы.");
    }
}

//Вариант 2
//Строка ведь тоже, по-сути, массив. Со своей длинной и индексами. 
void GetThreNumberVers2()
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine();
    try
    {
        int num = Int32.Parse(number);
        if (number.Length > 2)
        {
            Console.WriteLine(number[2]);
        }
        else
        {
            Console.WriteLine("Число меньше трёх.");
        }
    }
    catch
    {
        Console.WriteLine("Введено не число.");
    }
}

//Здесь вызовы обоих методов.
ImputAndExamMumber(); //1-й
GetThreNumberVers2(); //2-й