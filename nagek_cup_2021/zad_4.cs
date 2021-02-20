using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    class zad_4
    {
        public static void print()
        {
            Console.WriteLine("Задание 5");
            int summ = 0, i = 0, count = 0,f;
            while(summ < 1000000)
            {
                f = Fibonachi(i);
                Console.WriteLine(f);
                if (f % 2 == 0)
                {
                    summ += f;
                    count++;
                }
                i++;
            }
            Console.WriteLine(count);
        }
        static int Fibonachi(int n)
        {
            return (n == 0 || n == 1) ? n : Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }

}
