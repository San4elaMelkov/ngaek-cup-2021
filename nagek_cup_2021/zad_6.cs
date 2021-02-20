using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    class zad_6
    {
        public static void print()
        {
            Player pl1 = new Player("Cаша");
            Player pl2 = new Player("Влад");
            List<double> S = Generator(10);
            while (S.Count > 1)
            {
                Console.WriteLine($"{pl1.Name} выбирает какое число убрать: ");
                int isLast = -1;
                while(isLast < 0 || isLast > 1)
                {
                    Console.WriteLine("0 - Первое число, 1 - Последнее");
                    isLast = Convert.ToInt32(Read("Введите число: "));
                }
                Check(pl1, S, isLast);
                Console.Clear();
                Console.WriteLine($"{pl2.Name} выбирает какое число убрать: ");
                isLast = -1;
                while (isLast < 0 || isLast > 1)
                {
                    Console.WriteLine("0 - Первое число, 1 - Последнее");
                    isLast = Convert.ToInt32(Read("Введите число: "));
                }
                Check(pl2, S, isLast);
                Console.Clear();
            }
            Console.WriteLine("___________Победитель______________");
            Console.WriteLine();
            if (pl1.Score == pl2.Score)
            {
                pl1.Info();
                pl2.Info();
            }
            else if(pl1.Score > pl2.Score)
                pl1.Info();
            else
                pl2.Info();
        }
        static void Check(Player pl, List<double> mass, int isLast=0)
        {
            int len = mass.Count - 1;
            if (mass[0] == mass[len])
            {
                pl.Score += (int)mass[0];
                if(new Random().Next(0,1) == 0)
                    mass.RemoveAt(len);
                else
                    mass.RemoveAt(0);
            }
            else if(isLast == 0)
            {
                pl.Score += (int)mass[0];
                mass.RemoveAt(0);
            }
            else
            {
                pl.Score += (int)mass[len];
                mass.RemoveAt(len);
            }
        }
        public static string Read(string str = "")
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        static List<double> Generator(int n)
        {
            int i;
            List<double> mass = new List<double>();
            mass.Add(new Random().Next(10)); 
            for (i = 1; i < n; i++)
            {
                mass.Add((Math.Pow(mass[i - 1], 2) + 53) % 2021);
            }
            return mass;
        }
        class Player
        {
            private int score;
            public int Score 
            { 
                get
                {
                    return this.score;
                }
                set
                {
                    if(value > 0)
                    {
                        this.score = value;
                    }
                }
            }
            private string name;
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    if (value.Length > 2)
                    {
                        this.name = value;
                    }
                    else
                    {
                        Console.WriteLine("Длина имени не должна быть меньше 2");
                    }
                }
            }
            public void Info()
            {
                Console.WriteLine($"Имя: {this.Name}\n" +
                    $"Очки: {this.Score}");
                Console.WriteLine("_________________________________________");
            }
            public Player(string name, int score = 0)
            {
                this.name = name;
                this.score = score;
            }

        }
    }
}
