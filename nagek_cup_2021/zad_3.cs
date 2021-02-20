using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
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
