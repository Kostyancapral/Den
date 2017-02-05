using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, sum1=0, sum2=0;
            int N = 10, N1=10, N2=10, N3=10;

            while (N != 0)
            {
                Console.WriteLine("Выберите тип валюты из которой будет проводится перевод:");
                Console.WriteLine("1.Доллары");
                Console.WriteLine("2.Евро");
                Console.WriteLine("3.Гривна");
                Console.WriteLine("0.Выход из программы");
                N = Convert.ToInt32(Console.ReadLine());
                switch (N)
                {
                    case 1:
                        
                        while (N1 != 0)
                        {
                            Console.WriteLine("Выберете один из пунктов меню:");
                            Console.WriteLine("1.Ввод суммы");
                            Console.WriteLine("0.Возврат в предедущее меню");
                            N1 = Convert.ToInt32(Console.ReadLine());
                            switch (N1)
                            {
                                case 1:
                                    Console.ReadKey();
                                    Console.Clear();
                                    sum = 0;
                                    sum1 = 0;
                                    sum2 = 0;
                                    Console.WriteLine("Введите вашу сумму для перевода");
                                    sum = Convert.ToDouble(Console.ReadLine());
                                    sum1 = sum * 0.94;
                                    sum2 = sum * 28.075;
                                    Math.Round(sum1, 2);
                                    Math.Round(sum2, 2);
                                    Console.WriteLine("Ваша сумма в евро:" + sum1);
                                    Console.WriteLine("Ваша сумма в гривнах:" + sum2);
                                    break;
                                case 0:
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    case 2:
                        while (N2 != 0)
                        {
                            
                            Console.WriteLine("Выберете один из пунктов меню:");
                            Console.WriteLine("1.Ввод суммы");
                            Console.WriteLine("0.Возврат в предедущее меню");
                            N2 = Convert.ToInt32(Console.ReadLine());
                            switch (N2)
                            {
                                case 1:
                                    Console.ReadKey();
                                    Console.Clear();
                                    sum = 0;
                                    sum1 = 0;
                                    sum2 = 0;
                                    Console.WriteLine("Введите вашу сумму для перевода");
                                    sum = Convert.ToDouble(Console.ReadLine());
                                    sum1 = sum / 0.94;
                                    sum2 = sum * 29.975;
                                    Math.Round(sum1, 2);
                                    Math.Round(sum2, 2);
                                    Console.WriteLine("Ваша сумма в долларах:" + sum1);
                                    Console.WriteLine("Ваша сумма в гривнах:" + sum2);
                                    break;
                                case 0:
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    case 3:
                        while (N3 != 0)
                        {
                            
                            Console.WriteLine("Выберете один из пунктов меню:");
                            Console.WriteLine("1.Ввод суммы");
                            Console.WriteLine("0.Возврат в предедущее меню");
                            N3 = Convert.ToInt32(Console.ReadLine());
                            switch (N3)
                            {
                                case 1:
                                    Console.ReadKey();
                                    Console.Clear();
                                    sum = 0;
                                    sum1 = 0;
                                    sum2 = 0;
                                    Console.WriteLine("Введите вашу сумму для перевода");
                                    sum = Convert.ToDouble(Console.ReadLine());
                                    sum1 = sum / 28.075;
                                    sum2 = sum / 29.975;
                                    Math.Round(sum1, 2);
                                    Math.Round(sum2, 2);
                                    Console.WriteLine("Ваша сумма в долларах:" + sum1);
                                    Console.WriteLine("Ваша сумма в евро:" + sum2);
                                    break;
                                case 0:
                                    break;
                            }
                        }
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}
