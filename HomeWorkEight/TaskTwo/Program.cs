// ====== Задача №2: 
//     Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// ====== Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//     Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Первый этап.
int MinimalNumberElementArray(int[,] array)
{
    int row = array.GetLength(0);
    int colum = array.GetLength(1);
    //массив в который будет сохраняться сумма каждой строки.
    //Длинна соответсвует колличеству строк.
    int[] SumRowArray = new int[row];
    //прбегаемся по всему массиву.
    for (int i = 0; i < row; i++)
    {
        int tempSumElement = 0;
        for (int j = 0; j < colum; j++)
        {
            //и складываем все числа в каждой строке по отдельности..
            tempSumElement = tempSumElement + array[i, j];
        }
        //Вывод для контроля результата подстчёта.
        Console.WriteLine(tempSumElement);
        //Сумму каждой строки записываем в новый массив.
        SumRowArray[i] = tempSumElement;
    }
    //Возвращаем результат работы второго этапа.
    return MinElement(SumRowArray, row);
}

//Второй этап.
int MinElement(int[] array, int row)
{
    // простейший алгоритм поиска минимального числа
    // и его индекса
    int minNumber = array[0];
    int index = 0;
    for (int i = 1; i < row; i++)
    {
        if (minNumber > array[i])
        {
            minNumber = array[i];
            index = i;
        }
    }
    //возвращаем найденный индекс минимального числа,
    //соответвующего индексу строки в которой мы его нашли.
    //+ 1 позволяет при выводе вести отсчёт строк не с "0",
    //как того требует условие задачи.
    return index + 1;
}

//Распечатка массива. Что бы убедиться, что он прямоугольный.
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

//Массив тестовый. Прямоуголный. (:
int[,] rectangleIntegerArray = new int[,]{
    {3, 5, 3, 1, 0, 2, 9},
    {0, 2, 6, 1, 1, 7, 1},
    {1, 3, 5, 1, 0, 2, 9},
    {7, 4, 1, 1, 2, 5, 3},
};

//Массив из примера. Работает.
// int[,] rectangleIntegerArray = new int[,]{
// {1, 4, 7, 2},
// {5, 9, 2, 3},
// {8, 4, 2, 4},
// {5, 2, 6, 7}};

PrintArray(rectangleIntegerArray);
Console.Write($"Минимальная сумма в строке № {MinimalNumberElementArray(rectangleIntegerArray)};");

