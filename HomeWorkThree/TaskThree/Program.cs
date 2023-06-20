/*
Задача №3:

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/
int InputUserNumber()
{
    Console.Write("Введите число: ");
    int imputNumb = Convert.ToInt32(Console.ReadLine());
    return imputNumb;
}
void PrintTableCube(int imputNumb)
{
    double number = 0;
    Console.Write($"Таблица кубов:\n{imputNumb} -> ");
    for (int i = 1; i <= imputNumb; i++)
    {
        //Console.Write($"{number = i * i * i}, "); //Вариант первый, в лоб.
        Console.Write($"{number = Math.Pow(i, 3)}, ");
    }
}
int userNumber = InputUserNumber();
PrintTableCube(userNumber);
