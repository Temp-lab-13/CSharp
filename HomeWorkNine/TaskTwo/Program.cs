// ====== Задача №2: 
//     Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// ====== Пример:
//     M = 1; N = 15 -> 120
//     M = 4; N = 8. -> 30

//Распечатывает заданные числа и, результат вызываемого метода для их обработки.
void PrintSumNaturalNumber(int numberMin, int numberMax)
{
    //Проверяем, что числа натуральные и заданны в верном порядке. 
    //Для этого вызываем соответвующий булевый метод.
    if (CheckNaturalNuber(numberMin, numberMax))
    {
        Console.Write($"M = {numberMin}; N = {numberMax} -> ");
        Console.Write($"{SearchSumNaturalNumber(numberMin, numberMax)}");
    }
    //Если фолс, то будет общее сообщение об ошибке.
    else { Console.Write("Заданный диапозон не корректный"); }
}

//Метод проверяет, что бы числа были больше нуля, 
//а так же смотрит что бы N было больше M.
bool CheckNaturalNuber(int numberOne, int numberTwo)
{
    return numberTwo > numberOne && numberOne > 0;
}


//Метод получает два числа, и ищет сумму в заданном промежутке включительно.
//Резульат возращает в метод печати.
int SearchSumNaturalNumber(int numberMin, int numberMax)
{
    int sum = 0;
    //При достижении минимального числа в диапозоне, 
    //возращается это самое число, как последний элемент сложения.
    if (numberMin >= numberMax) return numberMin;

    sum += numberMax;

    return sum + SearchSumNaturalNumber(numberMin, numberMax - 1);
}

//Задём значения M и N, как указано в условии. 
int M = 1;
int N = 15;

PrintSumNaturalNumber(M, N);
