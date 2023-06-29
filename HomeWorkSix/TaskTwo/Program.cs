//====== Задача №2:
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//
//====== Пример:
//
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

using static System.Runtime.InteropServices.JavaScript.JSType;
//Вводим координаты. Название координаты задаётся при вызове, как передаваемый аргумент.
double ImputCoordinates(string сoordinate)
{
    Console.Clear();
    Console.Write($"Введите значение {сoordinate}: ");
    return Convert.ToDouble(Console.ReadLine());
}

//Отдельный метод для расчёта точки пересечения. 
//Можно было сделать по другому, и считать сразу результат для обеих точек, и их возвращать кортежем.
double CalculationCoordinate(double k1, double b1, double k2, double b2, string xY)
{
    double returnNumber = 0;
    if(xY == "x") returnNumber = (b2 - b1) / (k1 - k2);
    else if (xY == "y") returnNumber = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    return returnNumber;
}

//Метод первичной проверки координат, на совпадения.

void CheckСoordinates(double k1, double b1, double k2, double b2)
{
    //Если все координаты совпадают, то очевидно, что расположение отрезков идентично и они лежат друг на друге.
    if (k1 == k2 && b1 == b2) Console.Write($"Координаты совпадают, оба отрезка лежат друг на друге.");
    //Если совпадают только к1 и к2, то очевидно, что в 2д пространстве, прямые никогда не пересекутся,
    //а значит, они параллельны.
    else if (k1 == k2) Console.Write($"Прямые параллельны");
    //Если они таки пересекаются, то счиатем точку пересечения, вызывая в методе другой метод.
    else
    {
        double x = CalculationCoordinate(k1, b1, k2, b2, "x");
        double y = CalculationCoordinate(k1, b1, k2, b2, "y");
        Console.Write($"({x}; {y})");
    }
}
 //На самом деле, вот это по этапный вызов в 4 раза, ну такое себе. Можно было сделать всё через массивы.
 //Его отправлять, обсчитывать и даже его же и возвращать.
double k1 = ImputCoordinates("k1");
double b1 = ImputCoordinates("b1");
double k2 = ImputCoordinates("k2");
double b2 = ImputCoordinates("b2");
CheckСoordinates(k1, b1, k2, b2);

//TO-DO: Будет время, сделать вариант через массив, и сделать проверку на перпендикулярность линий.