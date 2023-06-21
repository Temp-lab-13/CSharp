/*
Задача №2: 

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11
    82 -> 10
    9012 -> 12
*/


int Imput()
{
    int number;
    Console.Write($"Введите любое число: ");
    while (int.TryParse(Console.ReadLine(), out number) == false)
    {
        Console.Write($"Введено не корректное число.\nВведите положительное натураьное  число: ");
    }
    return number;
}

int Сounting(int num)
{
    if (num < 0) num = num * -1;
    int length = (int)Math.Log10(num);
    int sum = 0;

    for (int i = 0; i <= length; i++)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}
int number = Imput();
Console.WriteLine($"Сумма цифр в числе: {Сounting(number)}");
