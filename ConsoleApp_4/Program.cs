// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Для решения задания использование цикла for является обязательным условием. Не использовать встроенный метод возведения в степень.
/*
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int step = a;
for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine($"{a} в степени {b} равно: {step}");

//-------------------------------
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Для решения задания использование цикла for является обязательным условием

int number = ReadInt("Введите число: ");

int D = NumberD(number);
SumNumbers(number, D);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberD(int A)
{
    int index = 0;
    while (A > 0)
    {
        A /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int N, int D)
{
    int sum = 0;
    for (int i = 1; i <= D; i++)
    {
        sum += N % 10;
        N /= 10;
    }
    Console.WriteLine($"Сумма цифр {sum}");
}

//-------------------------------
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Заполнение массива производит пользователь.

int [] numbers = new int[8];
Console.Write("*");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("*");

int Method (int a)
{
    return numbers[a];
}