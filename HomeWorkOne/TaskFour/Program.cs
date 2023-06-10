/* Задача №4:
 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Прорграмма по поиску всех чётных числе от 1 до указанного числа.\n");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter;
if (number > 0)
{
    counter = 2;
    while (number >= counter)
    {
        Console.Write($"{counter} ");
        counter += 2;
    }
}
else if (number < 0)
{
    counter = -2;
    while (number <= counter)
    {
        Console.Write($"{counter} ");
        counter -= 2;
    }
}
else
{
    Console.Write("Число равно 0");
}






