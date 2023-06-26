// ==== Задача №2: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// ==== Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Запрашиваем ввод длины массива и минимальное и максимальное значение генерируемы чисел. 
//Проверяем ввод на корректность длины массива, и вводимых чисел.
int ImputSArrayDate(int option)
{
    switch (option)
    {
        case 1:
            Console.Write("Введите длину массива: ");
            break;
        case 2:
            Console.Write("Введите нижний диапозон возможных чисел: ");
            break;
        case 3:
            Console.Write("Введите верхний диапозон возможных чисел: ");
            break;
    }
    int date = 0;

    while (int.TryParse(Console.ReadLine(), out date) == false || option == 1 && date <= 0)
    {
        Console.Write("Введена не корректные символы. Попробуйте ещё раз: ");
    }
    return date;
}

//Передаём плученную длину массива со значениями мин и макс, и заполняем случайными числами в заданном диапазоне.
//Массив возвращаем.
int[] GetArray(int length, int min, int max)
{
    int[] arrayNum = new int[length];
    Random randomNumber = new Random();
    for (int i = 0; i < length; i++)
    {
        arrayNum[i] = randomNumber.Next(min, max);
    }
    return arrayNum;
}

//Передаём полученный массив, и его ранее полученную длину.
//Считаем сумму элементов на начётных позиция (с единицы), и возвращаем результат.
int SumEvenNumber(int[] array, int length)
{
    int sum = 0;
    for (int i = 1; i < length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

//Распечатываем массив и результат.
void PrintSumEvenNumber(int sum, int[] array)
{
    Console.Write($"{string.Join(" ", array)} -> {sum}");
}


int length = ImputSArrayDate(1);
int min = ImputSArrayDate(2);
int max = ImputSArrayDate(3);
int[] arrayNumber = GetArray(length, min, max);
int sumEvenNumber = SumEvenNumber(arrayNumber, length);
PrintSumEvenNumber(sumEvenNumber, arrayNumber);