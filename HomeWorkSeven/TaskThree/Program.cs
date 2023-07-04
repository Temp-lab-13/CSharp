//====== Задача №3: 

//    Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//====== Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System.Numerics;

//Метод запрашивает размеры массива.
//И традиционно проверяет ввод на число.
int SizeArray(string nameSize)
{
    int size = 0;
    //Отдельная перменная, принимающая строку, которая говорит что вводим.
    Console.Write(nameSize);
    while (int.TryParse(Console.ReadLine(), out size) == false || size < 1)
    {
        Console.Write("Введена не корректная длина массива. Попробуйте ещё раз: ");
    }
    return size;
}

//Метод создаёт двумерный массив по полученным размерам, а после заполняет целыми числами.
int[,] CreatArrayInteger(int oneSize, int twoSize)
{
    //двумерный массив
    int[,] arrayNumberInteger = new int[oneSize, twoSize];
    //переменные задающие диапозон создания чисел для рандома.
    //Можно менять в ручную, можно скорректировать метод на получение вводом с консоли. 
    int minNumber = 1;
    int maxNumber = 9;
    //Прстым двойным циклом заполняем весь массив.
    for (int i = 0; i < oneSize; i++)
    {
        for (int j = 0; j < twoSize; j++)
        {
            arrayNumberInteger[i, j] = new Random().Next(minNumber, maxNumber);
        }
    }
    //возвращаем массив.
    return arrayNumberInteger;
}

//Метод расчёта среднеаре-аметического.
//Принимает созданный массива, его ранее введёные размеры.
//возвращает одномерный массив с результатами.
double[] CalculetionArithmeticMean(int[,] array, int oneSizeArray, int twoSizeArray)
{
    //массив куда будем ложить результаты расчёта по каждому столбцу.
    //размер равен длине строки.Т.е. колличеству столбцов
    double[] arrayTemp = new double[twoSizeArray];

    //Задаём циклом позицию по строке.
    for (int i = 0; i < twoSizeArray; i++)
    {
        //перебираем сами строки.
        for (int j = 0; j < oneSizeArray; j++)
        {
            //суммируем элементы каждого солбца.
            arrayTemp[i] = arrayTemp[i] + array[j, i];
        }
        //делим получившуюся сумму на колличесвто элементовю.
        //И сохраняем в возвращаемый массив, предварительно откинув лишнии цифры после запятой.
        arrayTemp[i] = Math.Round((arrayTemp[i] / (oneSizeArray)), 1, MidpointRounding.ToZero);
    }
    //возвращаем массив с результатами.
    return arrayTemp;
} 

//Печатаем результаты.
void PrintArray(double[] array, int[,] arraytwo)
{
    //Сначала печатаем наш массив.
    for (int i = 0; i < arraytwo.GetLength(0); i++)
    {
        for(int j = 0;j < arraytwo.GetLength(1); j++) Console.Write($"{arraytwo[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine("===================");
    //А потом печатаем результаты наших расчётов.
    Console.Write($"Среднее арефметическое кадого столбца: {string.Join("; ", array)}.");
}
int oneSizeArray = SizeArray("Введите горизонтальный размер двумерного массива: ");
int twoSizeArray = SizeArray("Введите вертикальный размер двумерного массива: ");
int[,] arrayNumberInteger = CreatArrayInteger(oneSizeArray, twoSizeArray);
double[] arrayArithmeticMean = CalculetionArithmeticMean(arrayNumberInteger, oneSizeArray, twoSizeArray);
PrintArray(array: arrayArithmeticMean, arraytwo: arrayNumberInteger);
Console.ReadKey();
