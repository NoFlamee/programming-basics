using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int weight, age, height;
            Console.WriteLine("Введите ваше имя ");
            name = Console.ReadLine();
            Console.WriteLine("\nВведите вашу фамилию ");
            surname = Console.ReadLine();
            Console.WriteLine("\nВведите ваш возраст ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите ваш рост ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите ваш вес ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + " " + surname + " " + "Возраст " + age + " " + "Рост " + height + " " + "Вес " + weight);
            Console.WriteLine("{0} {1} Возраст {2} Рост {3} Вес {4}", name, surname,age,height,weight);
            Console.WriteLine($"{name} {surname} Возраст {age} Рост {height} Вес {weight}");
        }
    }
}
