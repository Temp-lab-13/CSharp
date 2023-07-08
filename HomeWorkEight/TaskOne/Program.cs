//====== Задача №1: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//====== Пример:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//  В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Метод печати двумерного массива. 
void PrintArray(int[,] array)
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

//Метод сортировки чисел в кадой отдельной строке массива,
// от большего к меньшему.
//Принимает сам массив и индекс обрабатываемой строки.
int[,] SortNumbersArray(int[,] arrayInteger, int stringArray)
{
    int tempNumber = 0;
    int index = 0;
    //нам нужна длина только обрабатываемой строки.
    int length = arrayInteger.GetLength(1);
    //Сортировка выбором для одномерного массива, 
    //модифицирована добавлением индекста строки,
    //котрую мы берём из принимающих методом аргументов.
    for (int i = 0; i < length - 1; i++)
    {
        tempNumber = arrayInteger[stringArray, i];
        index = i;
        for (int j = i + 1; j < length; j++)
        {
            if (tempNumber < arrayInteger[stringArray, j])
            {
                tempNumber = arrayInteger[stringArray, j];
                index = j;
            }
        }
        arrayInteger[stringArray, index] = arrayInteger[stringArray, i];
        arrayInteger[stringArray, i] = tempNumber;
    }
    //финт ушами. 
    //проверяем: есть ли ещё строки в массиве, 
    //путём сравнивания текущего значения строки значения 
    //с общим колличеством строк массива. 
    //Если если есть ещё строки, то проваливаемся в If.
    if (stringArray < arrayInteger.GetLength(0) - 1)
    {
        //И вызываем метод по новой
        //попутно увеличивая индекс строк массива.
        //результат возвращаем. 
        return SortNumbersArray(arrayInteger, stringArray + 1);
    }
    //возращаем обработанный массив.
    return arrayInteger;

}

int[,] CreateIntegerArray(int line, int column, int minIntegerNumber, int maxIntegerNumber)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(minIntegerNumber, maxIntegerNumber);
        }
    }
    return array;
}

//Задаём двумерный массив, как в примере для наглядности. 
int[,] arrayNumbers = new int[,] {
     {1, 4, 7, 2},
     {5, 9, 2, 3},
     {8, 4, 2, 4},
     {1, 0, 9, 3},
     {0, 0, 1, 1}
 };
int LineZerro = 0;
int[,] testArray = CreateIntegerArray(8, 8, 0, 50);

arrayNumbers = SortNumbersArray(arrayNumbers, LineZerro);
Console.WriteLine("Отсортированный массив из примера:");
PrintArray(arrayNumbers);

Console.WriteLine("Не отсортированный рандомный массив:");
PrintArray(testArray);
Console.WriteLine("Отсортированный рандомный массив:");
testArray = SortNumbersArray(testArray, LineZerro);
PrintArray(testArray);

//ToDO: попробовать другие сортировки.