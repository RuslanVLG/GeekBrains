//ЗАДАЧА 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int A, B, C;
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int max = num;
if (max < 100 || max > 999)
{
    Console.WriteLine($"Число {max} не соответсвует условию");
}
else
{
    A = max / 10;
    B = (A / 10) * 10;
    C = A - B;
    Console.WriteLine($"Число {C} является вторым");
}

//--------------------------------------
// ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int A;
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int max = num;
if (max < 100)
{
    Console.WriteLine($"Число {max} содержит меньше 3 цифр и не соответсвует условию");
}
else if (max > 1000)
{
    Console.WriteLine($"Число {max} содержит больше 3 цифр и не соответсвует условию");
}
else
{
    A = max % 10;
    Console.WriteLine($"Ваша цифра: {A}");
}

//--------------------------------------
//  ЗАДАЧА 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int A;
Console.Write("Введите число:");
int numday = Convert.ToInt32(Console.ReadLine());
{
    if (numday > 0 && numday < 8)
    {
        if (numday == 6 || numday == 7)
            Console.WriteLine($"Этот день {numday} - выходной");
        else Console.WriteLine($"Этот день {numday} - рабочий");
    }
    else Console.WriteLine($"Число не сооттветсвует дню недели");
}
