using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11_Практика_Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели.");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите номер дня недели.");
            string name2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите дату.");
            string name3 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"День недели: {name1}, Номер дня недели: {name2}, Дата: {name3}");
            Console.ReadKey();

        }
    }
}
