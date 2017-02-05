using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasvord = "root", vvod="";
            Console.WriteLine("Введите пароль.");
            vvod = Convert.ToString(Console.ReadLine());
            if (vvod == pasvord)
            {
                Console.WriteLine("Пароль верный.");

            }
            if (vvod != pasvord)
            {
                do
                {

                    if (vvod != pasvord)
                    {
                        Console.WriteLine("Пароль не верный. Введите еще раз.");
                        vvod = Convert.ToString(Console.ReadLine());
                    }
                    if (vvod == pasvord)
                    {
                        Console.WriteLine("Пароль верный.");
                        break;
                    }
                }
                while (vvod != pasvord);
            }
            Console.ReadKey();
        }
    }
}
