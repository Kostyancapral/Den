using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool flag = true;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Данное число является простым");
            else
                Console.WriteLine("Данное число не является простым");

            Console.ReadKey();
        }
    }
}
