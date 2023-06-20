// See https://aka.ms/new-console-template for more information

int[] array = { 1, 2, 3 };
Console.Write(string.Join(" ", array));//Быстрый способ распечатать массив.
int num = 1246;
int length = (int)Math.Log10(num) + 1; //Быстрый способ получить длину числа. Через логорифм.
Console.WriteLine();
Console.Write(length);