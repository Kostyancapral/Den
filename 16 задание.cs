using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 32, r = 0, kol = 64, k;
            k = (kol / 4) + 1;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Количество кроликов " + r + ", количество гусей " + g);
                g = g - 2;
                r = r + 1;
            }
            Console.ReadKey();
        }
    }
}
