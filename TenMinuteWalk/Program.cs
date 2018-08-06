using System;

namespace TenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s"};

            Console.WriteLine(IsValidWalk(test));

            Console.ReadLine();
        }

        public static bool IsValidWalk(string[] walk)
        {
            int nCounter = 0;
            int sCounter = 0;
            int eCounter = 0;
            int wCounter = 0;

            if (walk.Length != 10)
            {
                return false;
            }

            return true;
        }
    }
}


// Algorithm is that there must be an equal ammount of S as N and E as W.