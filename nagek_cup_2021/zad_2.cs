using System;
using System.Collections.Generic;
using System.Text;

namespace nagek_cup_2021
{
    /*
     *№2. Создать квадратную матрицу вида 
        0 5 8 2 3 9 0
        5 0 5 4 6 0 9
        8 5 0 7 0 7 8
        2 4 7 0 6 5 4
        3 6 0 6 0 4 4
        9 0 7 5 4 0 8
        0 9 8 4 4 8 0
        Размер матрицы ввести с клавиатуры, при заполнении элементами ввод с клавиатуры не использовать.
        Все элементы случайные, кроме диагональных. Матрица симметрична относительно главной диагонали. (10 баллов)
    */
    class zad_2
    {
        public static void print()
        {
            Console.WriteLine("Задание 2");
            int n = Convert.ToInt32(Read("Введите длину массива"));
            int i,j;
            List<List<int>> Matrix = Generator(n, 0, 10);
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    Matrix[i][j] = (i == j)?0: Matrix[i][j];
            PrintMatrix(Matrix);
            Console.WriteLine("--");
            Matrix = SimmetrMatrix(Matrix);
            PrintMatrix(Matrix);
        }
        static List<List<int>> SimmetrMatrix(List<List<int>> matrix)
        {
            int i,j;
            for (i = 0; i < matrix.Count; i++)
                for (j = 0; j < matrix[i].Count; j++)
                    matrix[i][j] = matrix[j][i];
            return matrix;
        }
        public static List<List<int>> Generator(int length, int min, int max)
        {
            Random rnd = new Random();
            List<List<int>> Mas = new List<List<int>>();
            List<int> row = new List<int>();
            for (int i = 0; i < length; i++)
            {
                row = new List<int>();
                for (int j = 0; j < length; j++)
                    row.Add(rnd.Next(min, max));
                Mas.Add(row);
            }
            return Mas;
        }
        public static void PrintMatrix(List<List<int>> mass)
        {
            for (int i = 0; i < mass.Count; i++)
            {
                for (int j = 0; j < mass[i].Count; j++)
                    Console.Write(mass[i][j] + " ");
                Console.WriteLine();
            }

        }
        public static string Read(string str = "")
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
    }
}
