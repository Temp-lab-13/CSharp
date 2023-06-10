/* Задача№ 3:
 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
try
{
    Console.WriteLine("Программа по проверки числа на чётноесть.\n");
    Console.Write("Введетие число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int resalt = number % 2;
    if (resalt == 0)
    {
        Console.Write("Число чётное!");
    }
    else
    {
        Console.Write("Число не чётное!");
    }
}
catch
{
    Console.Write("Введены не корректные символы.");
}

