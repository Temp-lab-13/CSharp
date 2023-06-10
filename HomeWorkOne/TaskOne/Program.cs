/* Задача №1:
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число для сравнения: ");
//Прменил предложенный преподователем вариант.
//По сути, конструкция: int.TryParse(<сюда ложиться переменная или воодятся данные>, out int <преобразованная в число строка>);
// позволяет преобразовать строку в число, и проверить успешность этого преобразования. 
//При этом, false  обрабатывается как исключение и машина не падает, что позволяет не использовать try/catch. 
// Получаемое true или false можно присовить в булевую переменную и использовать.
// Если преобразование успешно, то можно использовать конечную переменную дальше. 
bool numOneTrue = int.TryParse(Console.ReadLine(), out int numberOne);
Console.Write("Введите второе число для сравнения: ");
bool numTwoTrue = int.TryParse(Console.ReadLine(), out int numberTwo);
if (numOneTrue == false || numTwoTrue == false)
{
    Console.Write("Введены не корректные символы.");
}
else if (numberOne > numberTwo)
{
    Console.Write($"Число {numberOne} больше, чем число {numberTwo}");
}
else if (numberOne < numberTwo)
{
    Console.Write($"Число {numberTwo} больше, чем число {numberOne}");
}
else
{
    Console.Write("Числа равны.");
}





