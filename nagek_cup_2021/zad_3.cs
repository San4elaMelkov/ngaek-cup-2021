using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    /*
         №3. У числа 24 восемь делителей: 1, 2, 3, 4, 6, 8, 12 и 24. 
        Существует десять чисел не больше 100, имеющих ровно восемь делителей: 24, 30, 40, 42, 54, 56, 66, 70, 78 и 88.
        Определить, сколько чисел не больше 10000000 имеют ровно 8 делителей. (20 баллов)
    */
    class zad_3
    {
        public static void print()
        {
            Console.WriteLine("Задание 3");
            int i,j=0, count=0, n=100000, divider=8;
            List<int> numbers = new List<int>();
            for (i = 2; i <= n; i++)
            {
                count = 1;
                for (j = 2; j <= i; j+=2)
                {
                    if (i % j == 0)
                        count++;
                    if (i % (j + 1) == 0)
                        count++;
                    if (count > divider)
                        break;
                }
                
                if (count == divider)
                    numbers.Add(i);
            }
            Console.WriteLine($"{numbers.Count} чисел которые имеют {divider} делителей");
        }
    }
}
