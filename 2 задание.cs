using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Второе_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string cat = "мяу", dog = "гав", world;
            Console.WriteLine("Введите слово");
            world = Console.ReadLine();
            if (cat == world)
            {
                Console.WriteLine("Покорми кота");
            }
            else
            {
                if (dog == world)
                {
                    Console.WriteLine("Покорми собаку");
                }
                else
                {
                    Console.WriteLine("Некого кормить");
                }
            }
            Console.ReadKey();
        }
    }
}
