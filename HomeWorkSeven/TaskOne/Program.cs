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

//Запрашиваем размер массива.
//Проверям на корректность ввода.
int SizeArray(string nameSize)
{
    int size = 0;
    //В переменную передаётся при вызове строка с описанием что нао вводить.
    Console.Write(nameSize);
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
    {
        Console.Write("Введена не корректная длина массива. Попробуйте ещё раз: ");
    }
    return size;
}

//Создаём по заданным размерам двумерный массив.
//И заполняем вещественными числами.
double[,] CreatArrayDouble(int oneSize, int twoSize)
{
    //сам двумерный массив, пока пустой.
    double[,] doubles = new double[oneSize, twoSize];
    //переменные регулирующие диапозон в котором генерируются числа.
    int minNumber = 10;
    int maxNumber = minNumber * 2;
    //переменная регулирует колличество знаков после запятой.
    int comma = 1;
    //Цикл в цикле, пробегается по всем уровням и заполняет массив вещественными числами.
    for (int i = 0; i < oneSize; i++)
    {
        for (int j = 0; j < twoSize; j++)
        {
            doubles[i, j] = Math.Round(new Random().NextDouble() * maxNumber - minNumber,
            comma, MidpointRounding.ToZero);
        }
    }
    //возвращаем двумерный массив.
    return doubles;
}

//Метод печати, что бы видеть что всё сработало.
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
//m и n взяты из задачи для наглядности. Я знаю что так называть переменные нельзя.
int m = SizeArray("Введите первый размер двумерного массива m: ");
int n = SizeArray("Введите второй размер двумерного массива n: ");
double[,] arrayDouble = CreatArrayDouble(m, n);
PrintArray(arrayDouble);