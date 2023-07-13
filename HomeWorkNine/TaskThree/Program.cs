// ====== Задача №3: 
//     Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// ====== Например:
//     m = 2, n = 3 -> A(m,n) = 9
//     m = 3, n = 2 -> A(m,n) = 29

int СomputeAkkermann(int numberM, int numberN)
{
    for (; numberM != 0; numberM--)
    {
        if (numberN != 0)
        {
            numberN = СomputeAkkermann(numberM, numberN - 1);
        }
        else
        {
            numberN = 1;
        }
    }
    return numberN + 1;
}

int СomputeAkkermannrmanV2(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0)
    {
        return numberN = СomputeAkkermann(numberM - 1, 1);
    }
    else
    {
        return numberN = СomputeAkkermann(numberM - 1, СomputeAkkermann(numberM, numberN - 1));
    }
}

Console.WriteLine(СomputeAkkermann(2, 3));
Console.WriteLine(СomputeAkkermann(3, 3));
Console.WriteLine(СomputeAkkermann(3, 4));
Console.WriteLine(СomputeAkkermannrmanV2(3, 2));

//  Как то в предыдущих задачах у меня вообще не было проблем с представлением и использованием рекурсий
//  но, от Аккермана у меня натурально расплавился мозг.
//  ):