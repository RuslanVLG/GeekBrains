// Урок 1. Знакомство с языком программирования С#

int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. На вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("2. Принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("3. На вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("4. На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

            Console.WriteLine("Вводите первое число: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Вводите второе число: ");
            int second_number = Convert.ToInt32(Console.ReadLine());

            if (first_number > second_number)
            {
                Console.WriteLine("Первое число " + first_number + " больше чем второе " + second_number);
            }
            else
            {
                Console.WriteLine("Второе число " + second_number + " больше чем первое " + first_number);
            }
            break;

        case 2:
            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            Console.WriteLine("Введите 3 числа:");
            int number_a = Convert.ToInt32(Console.ReadLine());
            int number_b = Convert.ToInt32(Console.ReadLine());
            int number_c = Convert.ToInt32(Console.ReadLine());

            int max = number_a;

            if (number_b > max)
            {
                max = number_b;
            }

            if (number_c > max)
            {
                max = number_c;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);
            break;

        case 3:
            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
            }
            break;

        case 4:
            // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

            int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
            break;

        default:
            begin = false;
            break;
    }
}