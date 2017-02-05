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
            double sum = 0;
            int j = 0;
            int[] M = new int[5];

            for (int i = 0; i < 5; i++)
            {
                j = j + 1;
                Console.WriteLine("Введите " + j + "-е число");
                M[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + M[i];
            }

            sum = sum / 5;
            Console.WriteLine("Среднее арифметическое ваших чисел равно " + sum);
            Console.ReadKey();
        }
    }
}
