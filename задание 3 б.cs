using System;

namespace задание_3_б
{

    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Введите x-вую координату первой точки ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y-вую координату первой точки ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x-вую координату второй точки");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y-вую координату второй точки");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расстояние между точками равно {0}", couting(x1, x2, y1, y2));
        }
        static double couting(int x1, int x2, int y1, int y2)
        {
            double r;

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
    }
}