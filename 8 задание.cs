using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double stavka = 0;
            int x=0;
            Console.WriteLine("Введите вашу ставку");
            stavka = Convert.ToDouble(Console.ReadLine());

            Random r = new Random();
            x = r.Next(1, 12);

            if (x > 0 && x < 6)
            {
                Console.WriteLine("Выпавшее значение " + x);
                Console.WriteLine("Вы проиграли.");
            }
            else
            {
                if (x > 5 && x < 9)
                {
                    Console.WriteLine("Выпавшее значение " + x);
                    Console.WriteLine("Вы выграли. Ваш выграш составляет: " + stavka);
                }
                else
                {
                    if (x > 8 && x < 12)
                    {
                        stavka = stavka * 2;
                        Console.WriteLine("Выпавшее значение " + x);
                        Console.WriteLine("Вы выграли. Ваш выграш составляет: " + stavka);
                    }
                    else
                    {
                        stavka = stavka * 10;
                        Console.WriteLine("Выпавшее значение " + x);
                        Console.WriteLine("Вы выграли. Ваш выграш составляет: " + stavka);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
