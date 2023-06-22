/*
Задача №3:

Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33]
*/

//Записываем в лист числа, которые вводит пользователь. 
//Это позволит ввесити негораниченное число элементов, и при этом узнать их колличество.
(List<int>, int) Imput() //метод, ничего не принимает, а возвращает сразу два разныех значения. Лист и счётчик.
{
    List<int> num = new List<int>(); //создаём лист.
    Console.WriteLine("Вводите числа, по одному, для формирования списка чисел.\nВведите любой символ кроме цифры, для завершения.");
    int index = 0; //Переменная, позволит отследить длину будущего массива, и видеть пользователю текущий индекс.
    while (true) //бесконечный цикл.
    {
        Console.WriteLine($"Введите число для индекса {index}: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            num.Add(number);
        }
        else
        {
            break; //любое не число, завершает работу цыкла и позволяет закончить ввод элементов. 
        }
        index++; //счётчик введённых элементов.
    }
    return (num, index); //возвращаем и лист и полученую длину будущего массива.
}
//Зная колличество введёных элементов, мы знаем какой длины нужен массив. 
//Создаём его и заполняем, переписывая сохранённые в листе элементы.
int[] CreatArray(List<int> num, int index) //метод заполняет массив.
{
    int[] array = new int[index]; //создаём массив с длинной равной значению полученному счётчиком введёных чисел из метода Imput..
    for (int i = 0; i < index; i++) //сдесь же эиспользуем всё то же полученное значение счётчика из Imput.
    {
        array[i] = num[i]; //в массив переписывам элементы сохранённые в листе.
    }
    return array;
}
//распечатываем.
void Print(int[] array) //Метод для печати в консоли.
{
    Console.WriteLine($"[{string.Join(", ", array)}]"); //просто печатаем весь массив, красиво его оформив.
}
(List<int> num, int index) = Imput(); //интресная запись для возвращения из метода нескольких разных значений.
int[] array = CreatArray(num, index);
Print(array);

//Конечно, можно пойти путём по проще, и не создавать, по сути - массив друго типа, что бы из него потом записать всё простой массив. 
//И, сначало запросить у пользователя длинну массива. Создать пустой массив нужного размера, 
//а потом уже запросить ввод чисел. До тех пор, пока не упрёмся в указанную длину массива.

//Как-то так:

int ImputLength()
{
    Console.Write("Укажите нужную длинну для новгго массива с учётом начала индексации от 0: ");
    int length = 0;
    while (int.TryParse(Console.ReadLine(), out length) == false || length < 0)
    {
        Console.Write("Введено не корректное значение длины массива. Попробуйте снова: ");
    }
    return length;
}

double[] CreatArrayVer2(int index)

{
    double[] array = new double[index];
    Console.WriteLine("Вводите числа, по одному, для формирования массива чисел.");
    for (int i = 0; i < index; i++)
    {
        Console.WriteLine($"Введите число для индекса {i}: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            array[i] = number;
        }
        else
        {
            Console.Write("Введён не корректный символ. Вводите только числа.");
            i = i - 1;
        }
    }
    Console.WriteLine();
    return array;
}


void PrintDouble(double[] array) //Метод для печати в консоли.
{
    Console.Write($"[{string.Join(", ", array)}]"); //просто печатаем весь массив, красиво его оформив.
}
int indexVer2 = ImputLength();
double[] array2 = CreatArrayVer2(indexVer2);
PrintDouble(array2);


//Так же можно через строку с вводом чисел через запяту или иной разделительный символ. Это позволит не запрашивать ни длинну,
//ни кажддое число по отдельности. Но этот метод я уже реализовывал в прерыдущих домашках, и потому оставлю лишь код с логикой.
/*
int[] ImputArray()
{
    Console.Write("Введите числа через запятую: ");
    string[] arr = Console.ReadLine().Split(",");
    int[] array = new int[arr.Length];
    int scor = arr.Length - 1;
    for (int i = 0; i < scor; i++)
    {
        array[i] = Convert.ToInt32(arr[i]);
    }
    return array;
}
*/
//Запрашиваем и распечатываем.


//Сортировка. По выбору.
double[] Sort(double[] array)
{
    double num = 0;
    int index = 0;
    int length = array.Length;


    for (int i = 0; i < length - 1; i++)
    {
        num = array[i];
        index = i;
        for (int j = i + 1; j < length; j++)
        {
            if (num > array[j])
            {
                num = array[j];
                index = j;
            }
        }
        array[index] = array[i];
        array[i] = num;
    }

    return array;
}

array2 = Sort(array2);
PrintDouble(array2);
