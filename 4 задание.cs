using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            string result;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());
            result = N != 0 ? "Хорошо" : "Плохо";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
