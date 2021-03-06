﻿using System;

namespace JosephusSurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JosSurvivor(300, 300));
            Console.ReadLine();
        }

        public static int JosSurvivor(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return (JosSurvivor(n - 1, k) + k - 1) % n + 1;
            }
        }
    }
}
