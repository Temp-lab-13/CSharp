
/* Задача №2:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
ХАРДКОД*/
try
{
    Console.WriteLine($"Программа для поиска максимального числа.\n");
    Console.Write("Введите первое число: ");
    int numOne = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int numTwo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int numThree = Convert.ToInt32(Console.ReadLine());

    if (numOne > numTwo)
    {
        if (numOne > numThree)
        {
            Console.Write($"Первое число {numOne} максимальное из трёх.");

        }
        else if (numOne == numThree)
        {

            Console.Write($"Первое число {numOne} и третье число {numThree} равны и больше числа {numTwo}");
        }

        else
        {
            Console.Write($"Третье число {numThree} максимальное из трёх.");
        }
    }
    else if (numOne == numTwo)
    {
        if (numOne > numThree)
        {
            Console.Write($"Превое число {numOne} и втореое число {numTwo} равны и больше числа {numThree}");
        }
        else
        {
            Console.Write("Все числа равны.");
        }
    }
    else if (numTwo > numThree)
    {
        Console.Write($"Второе число {numTwo} максимальное из трёх.");
    }
    else if (numTwo == numThree)
    {
        Console.Write($"Второе число {numTwo} и третье число {numThree} равны и больше числа {numOne}");
    }
    else
    {
        Console.Write($"Третье число {numThree} максимальное из трёх.");
    }
}
catch
{
    Console.Write("Введены не корректные символы.");
}