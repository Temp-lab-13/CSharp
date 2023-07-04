//====== Задача №1: 
//
//    Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
//====== Пример:
//
//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9

using static System.Net.Mime.MediaTypeNames;

int SizeArray(string nameSize)
{
    int size = 0;
    Console.Write(nameSize);
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1 )
    {
        Console.Write("Введена не корректная длина массива. Попробуйте ещё раз: ");
    }
    return size;
}

double[,] CreatArrayDouble(int oneSize, int twoSize)
{
    double[,] doubles = new double[oneSize, twoSize];
    int minNumber = 10;
    int maxNumber = minNumber * 2;
    int comma = 1;
    for (int i = 0; i < oneSize; i++)
    {
        for (int j = 0; j < twoSize; j++)
        {
           doubles[i, j] = Math.Round(new Random().NextDouble() * maxNumber - minNumber, 
           comma, MidpointRounding.ToZero);
        }
    }
    return doubles;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = SizeArray("Введите первый размер двумерного массива m: ");
int n = SizeArray("Введите второй размер двумерного массива n: ");
double[,] arrayDouble = CreatArrayDouble(m, n);
PrintArray(arrayDouble);