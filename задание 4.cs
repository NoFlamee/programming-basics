using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, t;
            Console.WriteLine("Введите первое число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            b = Convert.ToInt32(Console.ReadLine());
            t = a;
            a = b;
            b = t;
            Console.WriteLine($"Первое число равно {a} а второе {b}");
            Console.WriteLine("А теперь без использование третьей переменной");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Первое число равно {a} а второе {b}");
        }

    }
}
