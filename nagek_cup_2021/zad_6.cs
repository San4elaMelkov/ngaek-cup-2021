using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    /*
     * №6. Дана некоторая числовая последовательность S длиной N.
        Два игрока ходят по очереди.В свой ход каждый игрок должен выбрать, какое число больше:
        первое или последнее число в этой последовательности,
        и убрать его из нее.Если первое и последнее число одинаковы, выбирается одно из них случайным
        образом.Очки игрока равны сумме всех чисел, которые были им убраны.Побеждает тот игрок, который набирает большую сумму очков.
        Если N = 4 и S = { 5, 8, 3, 6}, тогда игра происходит следующим образом:
        - игрок 1: убирает последнее число(6)
        - игрок 2: убирает первое число из оставшейся последовательности(5)
        - игрок 1: убирает первое число из оставшейся последовательности(8)
        - Игрок 2: убирает оставшееся число(3)
        Игрок 1 получает 6 + 8 = 14 очков.
        Игрок 2 получает 5 + 3 = 8 очков.
        Игровая последовательность определена по следующим формулам:
        S[0] = 7; S[1] = ((S[0]) ^ 2 + 53) mod 2021 = 102; S[2] = ((S[1]) ^ 2 + 53) mod 2021 = 352; … ;
        S[i] = ((S[i - 1]) ^ 2 + 53) mod 2021. (^ 2 значит в квадрате). N=30.
        Определите победителя. (30 баллов)
    */
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
