// ====== Задача №3: 
//     Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// ====== Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
//     Результирующая матрица будет:
// 18 20
// 15 18

//метод печати двумерного массива.
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

//метод создания гибкой матрицы заполняемой случайными целыми числами, в указаннои диапозоне.
int[,] CreateMatrix(int line, int column, int minIntegerNumber, int maxIntegerNumber)
{
    int[,] matrix = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(minIntegerNumber, maxIntegerNumber);
        }
    }
    return matrix;
}

//Vетод переумнжающий две передаваемые в него матрицы.
//и возращающий результат в другую матрицу.
int[,] WorkMatrix(int[,] arrayOne, int[,] arrayTwo)
{
    //получаем размер матриц.
    int line = arrayOne.GetLength(0);
    int column = arrayOne.GetLength(1);

    //создаём матрицу, в которой храним результаты.
    int[,] resultWorkMatrix = new int[line, column];

    //Проверочка на то что обе матрицы одинакого размера.
    //Иначе етод может, и скорее всего не будет работать.
    if (line != arrayTwo.GetLength(0) || column != arrayTwo.GetLength(1))
    {
        Console.Write("Матрицы не равны.");
        return resultWorkMatrix;
    }

    //Верхний цикл идёт по длине первой матрицы.
    for (int i = 0; i < line; i++)
    {
        //нижный цикл без условия, оно проверяется отдельно. 
        //так как нам нужно работать сразу с тремя массивами,
        //нужно целых три переменных - счётчиков.
        //можно было просто использовать три цикла, но
        //я хотел ограничиться двумя.
        for (int j = 0, r = 0; ; j++)
        {
            //важно что бы счётчик j дойдя до ограничения,
            //т.е. до гринцы массива, сбрасывался.
            //а вторая переменна r, увеличивалась.
            //это позволяет перейти к записи следующего элемента в новый массив, 
            //и сдвинуть колонку на которую умножаем, во второй матрице. 
            if (j == column)
            {
                j = 0; r++; if (r == column) break;
                //Когда Второе число первой строки на всё умноажается,
                //выходим из цикла.
            }
            //переумножение элементов.
            resultWorkMatrix[i, r] += arrayOne[i, j] * arrayTwo[j, r];
        }
    }
    return resultWorkMatrix;
}

//тестовые массивы.
int[,] matrixOne = new int[,]{
    {2, 4},
    {3, 2}
};
int[,] matrixTwo = new int[,]{
    {3, 4},
    {3, 3}
};

int[,] testMatrixOne = CreateMatrix(2, 2, 10, 200);
int[,] testMatrixTwo = CreateMatrix(2, 2, 10, 200);

Console.WriteLine("Первая матрица:");
PrintArray(testMatrixOne);

Console.WriteLine("Вторая матрица:");
PrintArray(testMatrixTwo);

int[,] testTwoMatrix = WorkMatrix(testMatrixOne, testMatrixTwo);
Console.WriteLine("Произведение матриц:");
PrintArray(testTwoMatrix);

Console.WriteLine("Произведение матриц из примера:");
int[,] testMatrix = WorkMatrix(matrixOne, matrixTwo);
PrintArray(testMatrix);

//Долго вообще не мог сообразить, что от меня требуется. 
//Что на что должо множиться, что бы получились требуемые цифры?
//С калькулятором просидель долше, чем над кодом.
