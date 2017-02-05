using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double time=0, way=0, sum=0, way1=5, way2=0, time1=0;
            Console.WriteLine("Введите длину маршрута");
            way = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время простоя");
            time = Convert.ToDouble(Console.ReadLine());

            if (way > 5)
            {
                way2 = way - way1;
                way1 = way1 * 20;
                way2 = way2 * 3;
            }
            else
            {
                way1 = way;
                way1 = way1 * 20;

            }

            time1 = time * 1;

            sum = time1 + way1 + way2;

            Console.WriteLine("Сумма к оплате:" + sum);
            Console.ReadKey();
        }
    }
}
