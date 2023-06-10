/* Задача №1:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
try
{
    Console.Write("Введите первое число для сравнения: ");
    int numberOne = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число для сравнения: ");
    int numberTwo = Convert.ToInt32(Console.ReadLine());

    if (numberOne > numberTwo)
    {
        Console.Write($"Число {numberOne} больше, чем число {numberTwo}");
    }
    else if (numberOne < numberTwo)
    {
        Console.Write($"Число {numberTwo} больше, чем число {numberOne}");
    }
    else
    {
        Console.Write("Числа равны.");
    }
}
catch
{
    Console.Write("Введены не корректные символы.");
}