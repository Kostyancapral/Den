using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0, N = 0;
            Random r = new Random();
            X = r.Next(1, 146);

            do
            {
                Console.WriteLine("Введите число.");
                N = Convert.ToInt32(Console.ReadLine());
                if (N != X)
                {
                    if (N < X)
                    {
                        Console.WriteLine("Не верно. Загаданное число больше.");
                    }
                    else
                    {
                        Console.WriteLine("Не верно. Загаданное число меньше.");
                    }
                }
                else
                    Console.WriteLine("Поздравляем. Вы угадали число.");
            }
            while (N != X);

            Console.ReadKey();
        }
    }
}
