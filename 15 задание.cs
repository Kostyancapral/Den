using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int[] M = new int[5];
            Random r = new Random();

            Console.WriteLine("Числа ");
            for (int i = 0; i < 5; i++)
            {
                M[i] = r.Next();
                Console.WriteLine(M[i]);
                sum = sum + M[i];
            }
            sum = sum / 5;
            Console.WriteLine("Среднее арифметическое равно " + sum);
            Console.ReadKey();
        }
    }
}
