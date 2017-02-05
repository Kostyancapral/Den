using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            double N = 0, proiz=1;

            Console.WriteLine("Введите ваше число.");
            N = Convert.ToDouble(Console.ReadLine());

            if (N < 1)
            {
                Console.WriteLine("Введенное число не верно.");
            }
            if (N > 1)
            {
                while (N > proiz)
                {
                   
                    Console.WriteLine("Квадрат " + j + "-ого числа равен " + proiz);
                    j = j + 1;
                    proiz = j * j;
                }
               
            }

            Console.ReadKey();
        }
    }
}
