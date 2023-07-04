//Задача №2: 
//    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//    1 4 7 2
//    5 9 2 3
//    8 4 2 4

//17->такого числа в массиве нет

//Задаём массив. Просто руками.
int[,] arrayNumberInteger = new int[,]
{   { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2 ,4}
};

//Метод ввода.
(int iArrayPosition, int jArrayPosition) ImputPositionArray()
{
    //По сути здесь только получаем позицию по столбцу и строке. И возвращаем их.
    //Для этого вызваем отдельный метод.
    int i = CheckNumber("Введите позицию элемента по стобцам, счёт от 0: ");
    int j = CheckNumber("Введите позицию элемента массива по строке, счёт от 0: ");
    return (i, j);
};
//Метод проверки на число.
int CheckNumber(string position)
{
    //Метод инициализирующий сам ввод и проверку на корректность.
    int number;
    Console.Write(position);
    while (int.TryParse(Console.ReadLine(), out number) == false)
    {
        Console.Write("Введён не корректный символ, попробуйте снова: ");
    }
    Console.WriteLine();
    return number;
}

//Метод распечатки элемента.
void PrintElemetn(int i, int j, int[,] array)
{
    //Здесь печатаем запрашиваемый элемент, 
    //или говорим что элемента нет, елси запрос идёт за пределы массива.
    if (i < 0 || i > (array.GetLength(0) - 1))
    {
        Console.Write($"По адресу массива {i} и {j} элементы отсутвуют.");
        return;
    }

    if (j < 0 || j > (array.GetLength(1) - 1))
    {
        Console.Write($"По адресу массива {i} и {j} элементы отсутвуют.");
        return;
    }
    Console.Write($"\nЗапрашиваемый элемент: [{array[i, j]}].");
}
(int iPositionArray, int jPositionArray) = ImputPositionArray();
PrintElemetn(iPositionArray, jPositionArray, arrayNumberInteger);
Console.ReadKey();

