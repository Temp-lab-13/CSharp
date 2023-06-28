//====== Задача №1: 
//
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
//====== Пример:
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

List<double> ImputNumber()
{
    int count = 1;
    List<double> listNumber = new List<double>();
    Console.WriteLine("Введите желаемые числа по порядку. \n Для заверщения наберите: exit \n");
    do {
        Console.Write($"Введите {count} число: ");
        string exit = Console.ReadLine();
        if (TrueFalseExit(exit))
        {
            listNumber.Add(Convert.ToDouble(exit));
            count++;
        }
        else if (exit.ToLower() == "exit") break;
        else Console.WriteLine("Введено не корректное значение: " + exit + "Повторите ввод.\n ");
    } while (true);
    return listNumber;
}

bool TrueFalseExit(string imput)
{
    if (double.TryParse(imput, out _)) return true;
    return false;
}

(List<double>, int) Сalculation(List<double> list)
{
    
    for (int i = list.Count - 1; i > 0; i--)
    {
        if (list[i] <= 0) {
            list.RemoveAt(i);}
    }
    int count = list.Count;
    return (list, count);
}

void Print(List<double> list, List<double> list2, int count)
{
    Console.WriteLine($"[{string.Join(", ", list)}]");
    Console.Write($"[{string.Join(", ", list2)}] -> {count}");

}
List<double> list = ImputNumber();
(List<double> list2, int count) = Сalculation(list);
Print(list, list2, count);