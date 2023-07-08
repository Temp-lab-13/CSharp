// ====== Задача №5: 
//     Напишите программу, которая заполнит спирально массив 4 на 4.
// ====== Например: 
//     На выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int number = 01;

//Метод рачпечатывает двумерный массив в фрмате "00", "01" и тд.
void PrintArray(int[,] arrayFinish)
{
    for (int i = 0; i < arrayFinish.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFinish.GetLength(1); j++)
        {
            Console.Write($"{string.Format("{0:d2}", arrayFinish[i, j])} ");
        }
        Console.WriteLine();
    }
}

//Метод добавляет в двумерный массив число, по переданным координатам.
//И увеличивает число на +1.
void NumPlus(int[,] array, int line, int column)
{
    //Проверочка на отсутвие по коориданте уже записанного числа.
    //Рудемент, предыдущего решения.
    array[line, column] = number;
    number++;

}

//Метод проверяет полученный массив на наличие в нём "пустых" мест.
//Пустыми местами выступают "0".
bool CheckArrayNull(int[,] array, int line, int column)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] == 0) return true;
        }
    }
    return false;
}

//Метод заполняет массив числами по спирали. Улиткой.
void FillingArraySnail(int[,] array, int line, int column)
{
    //получаем границы полученного массива.
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    //Сначала, идёт заполнять впрао до упора, и вниз до упора..
    while (true)
    {
        //Старт. Сдесь записывается первое число.
        //Предварительно проверив место на "пустоту".
        if (array[line, column] == 0)
        {
            NumPlus(array, line, column);
            continue;
        }
        //Сначало идёт проверка на то не выходим ли мы за границу массива, следующим шагом.
        //После, идёт проверка, есть ли уже записанное (отличное от 0) число на следуещем шаге.
        else if ((column + 1) < col && array[line, (column + 1)] == 0)
        {
            //Если место пусто и оно ещё в пределах массива - "шагаем".
            column++;
            //вызываем метод добавления числа, и перезапускаем цикл.
            NumPlus(array, line, column);
            continue;
        }
        else if ((line + 1) < row && array[(line + 1), column] == 0)
        {
            line++;
            NumPlus(array, line, column);
            continue;
        }
        else { break; }
    }
    //Теперь назад и вверх. 
    //Цикл разбит на двое, что бы при шагах назад, не начали срабатывать первые условия.
    while (true)
    {
        //Всё тоже самое, но шаги теперь в обратном направлении.
        if ((column - 1) >= (col * 0) && array[line, (column - 1)] == 0)
        {
            column--;
            NumPlus(array, line, column);
            continue;
        }
        else if ((line - 1) >= (row * 0) && array[(line - 1), column] == 0)
        {
            line--;
            NumPlus(array, line, column);
            continue;
        }
        else { break; }
    }
    //Так как при первой итерации обоих циклов, заполняется только первый внешний ряд по кругу,
    //Необходимо его перезапустить, что бы заполнить внутренние, сколько бы их не было.
    //Для этого, после отработки циклов, отправляем массив на проверку.
    //Если массив не заполнен, метод вызывает себя заново, и продолжает заполнять массив.
    if (CheckArrayNull(array, row, col)) FillingArraySnail(array, line, column);
}

int[,] matrix = new int[4, 4];
int lineArray = 0;
int columnArray = 0;
FillingArraySnail(matrix, lineArray, columnArray);

PrintArray(matrix);



//На это не смотрите. Остатки не удавшегося эксперемента.
/*
while (row > i)
{
    if (NumPlus(matrix, j, i)) break;
    i++;
}

while (row > j)
{
    if (NumPlus(matrix, j, i)) break;
    j++;

}

while (row * 0 < i)
{
    if (NumPlus(matrix, j, i)) break;
    i--;
}

while (row * 0 < j)
{
    if (NumPlus(matrix, j, i)) break;
    j--;
}


i += 1;
j += 1;
*/