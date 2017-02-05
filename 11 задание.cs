using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            int r=0;
            Console.WriteLine("Введите ваше число");
            X = Convert.ToInt32(Console.ReadLine());
            do
            {
                r = r + 1;
                X = X / 10;
            }
            while ((Math.Abs(X)) > 0);
            Console.WriteLine("" + r);
            Console.ReadKey();
        }
    }
}
