
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

    if (numOne == numTwo && numTwo == numThree)
    {
        Console.Write("Все числа равны!");
    }
    else if (numOne > numTwo && numOne > numThree)
    {
        Console.Write($"Первое число {numOne} - максимальное.");
    }
    else if (numTwo > numThree && numTwo > numOne)
    {
        Console.Write($"Второе число {numTwo} - максимальное.");
    }
    else if (numThree > numOne && numThree > numTwo)
    {
        Console.Write($"Третье число {numThree} - максимальное.");
    }
    else
    {
        string equalNumber = numOne == numTwo ? "Первое и Второе" : numTwo == numThree ? "Второе и Третье" : "Первое и Третье";
        Console.Write($"Нет единственного максимального числа, так как {equalNumber} число равны.");
    }
}
catch (FormatException ex)
{
    Console.Write($"Введены не корректные символы.\n {ex.StackTrace}");
}