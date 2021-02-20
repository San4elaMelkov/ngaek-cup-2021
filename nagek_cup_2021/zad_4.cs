using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    /*
     * №4. Каждый новый член в последовательности Фибоначчи генерируется путем сложения двух предыдущих членов.
     * Начиная с 1 и 1, первые 10 слагаемых будут:
     *  1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
     *  Вычислите, для какого по номеру числа Фибоначчи сумма находящихся
     *  перед ним четных элементов впервые превысит 1000000. (20 баллов)
    */
    class zad_4
    {
        public static void print()
        {
            Console.WriteLine("Задание 4");
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
