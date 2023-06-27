﻿// ==== Задача №3: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным вещественной частью элементов массива.
// ==== Пример:
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 не релевантен.

//Я пытался. хD


//Ввод длины массива её возвращение. Мин и макс в этот раз вводиться не будут.
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

//Создание и заполнение массива (заданной длины) вещественными числам, после чего возвращаем этот массив. 
//Умножение на "100" позволяет сместить запятую вправо, добавив числам целых значений.
//"3" - позволяет ограничить число после запятой.
//Оба этих числа можно сделать задаваемыми с консоли, как в предыдущей задачке, но я этот момент здесь опущу.
//чисто для простоты.
double[] GetDoubleArray(int length)
{
    double[] numArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        numArray[i] = Math.Round(new Random().NextDouble() * 100, 3);
        //всё хорошо, но таким методом получить, скажем 12.1 - . т.е число с оной цифрой после запятой, почти не реально.
        //можно, конечно, сделать два цикла с разными условиями рандома, записывающие елементы в массив по очереди,
        //но как-то это... 0_о" да. 
    }
    return numArray;
}

//Выискиваем мин и макс среди вещественной части, потом считаем их разницу.
//Результат возвращаем.
double GetDifferenceNumber(double[] array, int length)
{
    //Здесь мы пезеаписываем первый элемент массива, отбрасывая его целую часть.
    //Так же ограничиваем длину после запятой, что бы избавиться от аппендиксов вычисления.
    //Я проверял, аапендиксы достаточно малы, что бы округдение не меняло вещественную часть в выбранном диапозоне.  
    array[0] = Math.Round(array[0] - Math.Truncate(array[0]), 3);
    //приписываем получившееся значение переменным. Плясать мы будем сразу от них.
    double min = array[0];
    double max = array[0];
    //Цикл. Переберает все элемены, начиная со второго, используя заранее полученную длину. 
    for (int i = 1; i < length; i++)
    {
        //с каждым номым сравниваемым элементом, мы делает тоже само, что и с первым/нулевым.
        array[i] = Math.Round(array[i] - Math.Truncate(array[i]), 3);
        //собственно сравниваем, находя мин и макс в массиве, без учёта целых частей чисел.
        //Так как нам по условию ведь ужно найти мин и мак именно среи вещественной части числа.
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    //находим разницу чисел.
    double resalt = max - min;
    //Возвращаем разницу чисел.
    return resalt;
}

void Print(double resalt, double[] array)
{
    //сначало хотел через форич, но запись получается корявая
    //да и ":f", несмотря на удобство, точно так же округляет как и Math.Round
    /*
    Console.Write($"[ ");
    foreach (double item in array)
    {
        Console.Write($"{item:f3} ");
    }
    Console.Write($"] -> {resalt}");
    */

    //выводим в консоль массив, ради чего делали Math.Round ещё при заполнении массива  
    //и результат. Так же ограничением по цифре после запятой. 
    Console.Write($"{string.Join(" ", array)} -> {Math.Round(resalt, 3)}");
}
int length = ImputLength();
double[] arrayDoubleNum = GetDoubleArray(length);
double difference = GetDifferenceNumber(arrayDoubleNum, length);
Print(difference, arrayDoubleNum);

//На самом деле, не знаю, можно ли это сделать проще,
//но мне больше не нравиться в этой истории то, что приходится округлять по последней цифре. 
//Как буд-то я из-за этого теряю точность и получаю другое число.
///Т.е из условного 0.4588 я хочу получить 0.458, но получаю 0.459.
//Метода же способного просто отбросить(без округления) не нужную часть после запятой в заданном диапозоне, я не на шёл.
//Хотя не знаю. Может быть, конечно, я просто фигнёй маюсь и всё норм. 
