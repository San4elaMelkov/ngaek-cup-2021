using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    class melkov
    {
        public static List<int> Generator(int length, int min, int max)
        {
            Random rnd = new Random();
            List<int> arr = new List<int>();
            for (int i = 0; i < length; i++)
                arr.Add(rnd.Next(min, max));
            return arr;
        }
        public static List<List<int>> Generator2x(int length1, int length2, int min, int max)
        {
            Random rnd = new Random();
            List<List<int>> Mas = new List<List<int>>();
            List<int> row = new List<int>();
            for (int i = 0; i < length1; i++)
            {
                row = new List<int>();
                for (int j = 0; j < length2; j++) row.Add(rnd.Next(min, max));
                Mas.Add(row);
            }
            return Mas;
        }
        public static void Whait(string str = "")
        {
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
            Console.Clear();
        }
        public static double Round(double value, int dec)
        {
            return Math.Floor(value * dec) / dec;
        }
        public static string Read(string str = "")
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        public static void PrintMass2x(List<List<int>> mass)
        {
            for (int i = 0; i < mass.Count; i++)
            {
                for (int j = 0; j < mass.Count; j++)
                    Console.Write(mass[i][j] + " ");
                Console.WriteLine();
            }

        }
    }
}
