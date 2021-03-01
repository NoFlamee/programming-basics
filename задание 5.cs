using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, city;
            Console.WriteLine("Введите ваше имя ");
            name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию ");
            surname = Console.ReadLine();
            Console.WriteLine("Введите ваш город проживания ");
            city = Console.ReadLine();
            Print(name, surname, city);
        }
        static void Print(string name, string surname, string city)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"{name} {surname} {city}");
        }
    }
}
