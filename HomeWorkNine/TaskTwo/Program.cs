// ====== Задача №2: 
//     Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// ====== Пример:
//     M = 1; N = 15 -> 120
//     M = 4; N = 8. -> 30

//Метод печати.
//Распечатывает заданные числа и результат вывываемого метода, для их обработки.
void PrintSumNaturalNumber(int numberMin, int numberMax)
{
    //Проверяем, что числа натуральные и заданны в верном порядке. 
    //Для этого вызываем соответвующий булевый метод.
    if (CheckNaturalNuber(numberMin, numberMax))
    {
        Console.Write($"M = {numberMin}; N = {numberMax} -> ");
        Console.Write($"{SearchSumNaturalNumber(numberMin, numberMax)}");
    }
    //Если нет, то будет общее сообщение об ошибке.
    //А мы даже не начнём расчёты.
    else { Console.Write("Заданный диапозон не корректный"); }
}

//Метод смотрит что бы числа были больше нуля, а так же
//смотрит что бы N было больше M.
bool CheckNaturalNuber(int numberOne, int numberTwo)
{
    return numberTwo > numberOne && numberOne > 0;
}

//Метод подсчёта суммы натурвльных чисел.
//Получает два числа, и ищет сумму в заданном промежутке включительно.
//Резульат возращает на печать.
int SearchSumNaturalNumber(int numberMin, int numberMax)
{
    int sum = 0;
    //При достижении минимального числа в диапозоне, 
    //возращается это самое число, как последний элемент сложения.
    if (numberMin >= numberMax) return numberMin;

    sum += numberMax;

    return sum + SearchSumNaturalNumber(numberMin, numberMax - 1);
}

//Задём числа, как указано в условии. 
int M = 1;
int N = 15;

PrintSumNaturalNumber(M, N);


//П.С. Я не стал описывать методы ввода через консоль,
//потому что делал это уже ни один раз, в прошлых задачах, 
//и вдоволь с этим навозился, а задание не про ввод.  
//По это й же причине в коде минимум обработки ошибок при неправлиьных вводных.
