using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    /*
     * №1. Из последовательности натуральных чисел, которые меньше 5000,
     * вычеркнем числа, которые делятся на 5, но не делятся на 10.
     * Вычислите сумму оставшихся чисел. (10 баллов)
     */
    class zad_1
    {
        public static void print()
        {
            Console.WriteLine("Задание 1");
            int i, m, n = 5000, sum = 0;
            for (i = 0; i < n; i++)
            {
                if (!(i % 10 != 0 & i % 5 == 0))
                    sum += i;
            }
            Console.WriteLine($"Сумма чисел, которые делятся на 5, но не делятся на 10 = {sum}");
        }
    }
}
