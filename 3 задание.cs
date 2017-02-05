using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Введите номер месяц");
            N = Convert.ToInt32(Console.ReadLine());
            if ((N < 3 && N>0) || N == 12)
            {
                Console.WriteLine("Зима");
            }
            else
            {
                if (N > 2 && N < 6)
                {
                    Console.WriteLine("Весна");
                }
                else
                {
                    if (N > 5 && N < 9)
                    {
                        Console.WriteLine("Лето");
                    }
                    else
                    {
                        if (N > 8 && N < 12)
                        {
                            Console.WriteLine("Осень");
                        }
                        else
                            Console.WriteLine("На этой планете такого месяца нет");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
