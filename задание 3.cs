using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            double r;
            Console.WriteLine("Введите x-вую координату первой точки ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y-вую координату первой точки ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x-вую координату второй точки");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y-вую координату второй точки");
            y2 = Convert.ToInt32(Console.ReadLine());
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками равно {r}");


        }
    }
}