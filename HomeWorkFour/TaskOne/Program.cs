/*
Задача №1:

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/
int Imput(int num)
{
    switch (num)
    {
        case 1:
            Console.Write($"Введите число которое будет основанием: ");
            break;
        case 2:
            Console.Write($"Введите число которое будет степенью: ");
            break;
    }
    int number;
    while (int.TryParse(Console.ReadLine(), out number) == false || number == 0)
    {
        Console.Write($"Введено не корректное число.\nВведите положительное натураьное  число: ");
    }
    return number;
}
void Conclusion(int numA, int numB, double resalt)
{
    Console.Write($"{numA}, {numB} -> {resalt}");
}
double Сounting(int numA, int numB)
{
    //решение циклом, как по условию.
    int resalt = numA;
    for (int i = 1; i < numB; i++)
    {
        resalt = resalt * numA;
    }
    return resalt;
    //Решение без цикла.
    //return Math.Pow(numA, numB);
}

int numA = Imput(1);
int numB = Imput(2);
Conclusion(numA, numB, Сounting(numA, numB));
