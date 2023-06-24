// ==== Задача №1: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// ==== Пример:
//     [345, 897, 568, 234] -> 2

//Запрашиваем ввод длины массива. Проверяем ввод нв корректность.
int ImputLength()
{
    int length = 0;
    Console.Write("Введите длину массива: ");
    while (int.TryParse(Console.ReadLine(), out length) == false || length <= 0)
    {
        Console.Write("Введена не корректная длина массива. Попробуйте ещё раз: ");
    }
    return length;
}

//Передаём плученную длину массива и заполняем случайными натуральными числами в заданном диапазоне.
//Массив возвращаем.
int[] GetArrayXXX(int length)
{
    int[] arrayNumXXX = new int[length];
    Random randomNumberXXX = new Random();
    for (int i = 0; i < length; i++)
    {
        arrayNumXXX[i] = randomNumberXXX.Next(100, 1000);
    }
    return arrayNumXXX;
}

//Предаём массив.
//Считаем колличество чётных чисел в заполненом массиве. 
//Результат возвращаем.
int EvenNumber(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

//Распечатываем массив и результат.
void PrintEvenNumber(int count, int[] array)
{
    Console.Write($"{string.Join(" ", array)} -> {count}");
}

int length = ImputLength();
int[] arrayNumber = GetArrayXXX(length);
int sumEvenNumber = EvenNumber(arrayNumber);
PrintEvenNumber(sumEvenNumber, arrayNumber);