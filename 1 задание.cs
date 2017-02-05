using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1=0, v2=0;
            Console.WriteLine("Введите первое число");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            v2 = Convert.ToDouble(Console.ReadLine());
            if (v1 > v2)
            {
                Console.WriteLine("Большое первое число:" + v1);
            }
            else
            {
                Console.WriteLine("Большое второе число:" + v2);
            }
            Console.ReadKey();

        }
    }
}
