// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
/*
void Print(int minNumber, int maxNumber)
{
    if (minNumber <= maxNumber)
    {
        Console.Write($"{minNumber} ");
        Print(minNumber + 1, maxNumber);
    }
}
Print(1, 5);
*/
/*
int Print(int oneNumber, int twoNumber)
{
    if (twoNumber == 0) return 1;
    return oneNumber * Print(oneNumber, twoNumber - 1);
}
Console.Write(Print(3, 5));
*/
