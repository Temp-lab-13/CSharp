/*
Задача №2:

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/
//int[] A = { 3, 6, 8 }; // тестовые массивы.
//int[] B = { 2, 1, -7 };

int[] ImputDotCoord()
{
    Console.Write("Введите коориднаты точки через запятую: ");
    string[] dot = Console.ReadLine().Split(",");
    int[] dotA = new int[dot.Length];
    int scor = dot.Length - 1;
    while (scor != -1)
    {
        dotA[scor] = Convert.ToInt32(dot[scor]);
        //Console.Write(dotA[scor]); //проверка на запись в массив.
        scor--;
    }
    return dotA;
}

double ShowDistanceCoord(int[] dotA, int[] dotB)
{
    int length = dotA.Length;
    double score = 0;
    for (int i = 0; i < length; i++)
    {
        score = score + Math.Pow((dotA[i] - dotB[i]), 2);
    }
    return score = Math.Round(Math.Sqrt(score), 2);
}

int[] dotA = ImputDotCoord();
int[] dotB = ImputDotCoord();
//for (int i = 0; i < dotA.Length; i++) //проверка, что метод возвращает корректное число.
//{
//    Console.Write(dotA[i]); 
//}

double distanc = ShowDistanceCoord(dotA, dotB);
Console.Write($"Расстояние между точка А и В равно: {distanc}.");


/*Работает только с вводом положительных цифр без символов.
int[] ImputDotCoord()
{
    Console.Write("Введите коориднаты точки: ");
    int dot = Convert.ToInt32(Console.ReadLine());
    int length = Math.Abs(dot).ToString().Length;
    int[] dotA = new int[length];
    int scor = length - 1;
    while (scor != -1)
    {
        dotA[scor] = dot % 10; ;
        dot = dot / 10;
        scor--;
    }
    return dotA;
}*/