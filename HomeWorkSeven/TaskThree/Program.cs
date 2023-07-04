//====== Задача №3: 

//    Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//====== Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System.Numerics;

int SizeArray(string nameSize)
{
    int size = 0;
    Console.Write(nameSize);
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
    {
        Console.Write("Введена не корректная длина массива. Попробуйте ещё раз: ");
    }
    return size;
}

int[,] CreatArrayInteger(int oneSize, int twoSize)
{
    int[,] arrayNumberInteger = new int[oneSize, twoSize];
    int minNumber = 1;
    int maxNumber = 9;
    for (int i = 0; i < oneSize; i++)
    {
        for (int j = 0; j < twoSize; j++)
        {
            arrayNumberInteger[i, j] = new Random().Next(minNumber, maxNumber);
        }
    }
    return arrayNumberInteger;
}

double[] CalculetionArithmeticMean(int[,] array, int oneSizeArray, int twoSizeArray)
{
    double[] arrayTemp = new double[twoSizeArray];
    for (int i = 0; i < twoSizeArray; i++)
    {
        for (int j = 0; j < oneSizeArray; j++)
        {
            arrayTemp[i] = arrayTemp[i] + array[j, i];
        }
        arrayTemp[i] = Math.Round((arrayTemp[i] / (oneSizeArray)), 1, MidpointRounding.ToZero);
    }
    return arrayTemp;
} 

void PrintArray(double[] array, int[,] arraytwo)
{
    for (int i = 0; i < arraytwo.GetLength(0); i++)
    {
        for(int j = 0;j < arraytwo.GetLength(1); j++) Console.Write($"{arraytwo[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine("===================");
    Console.Write($"Среднее арефметическое кадого столбца: {string.Join("; ", array)}.");
}

int oneSizeArray = SizeArray("Введите горизонтальный размер двумерного массива: ");
int twoSizeArray = SizeArray("Введите вертикальный размер двумерного массива: ");
int[,] arrayNumberInteger = CreatArrayInteger(oneSizeArray, twoSizeArray);
double[] arrayArithmeticMean = CalculetionArithmeticMean(arrayNumberInteger, oneSizeArray, twoSizeArray);
PrintArray(array: arrayArithmeticMean, arraytwo: arrayNumberInteger);
Console.ReadKey();
