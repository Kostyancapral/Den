using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = 0, proiz=0;
            Console.WriteLine("Введите ваше число");
            N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Таблица");
            for (int i = 1; i < 21; i++)
            {
                proiz = N * i;
                Console.WriteLine(i + "-е произведение равно " + proiz);
            }
            Console.ReadKey();
        }
    }
}
