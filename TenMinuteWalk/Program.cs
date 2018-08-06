using System;

namespace TenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = { "n", "s", "n", "n", "n", "s", "n", "s", "n", "s" };

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

            foreach (var coordinate in walk)
            {
                switch (coordinate)
                {
                    case "n":
                        nCounter++;
                        break;
                    case "s":
                        sCounter++;
                        break;
                    case "e":
                        eCounter++;
                        break;
                    case "w":
                        wCounter++;
                        break;
                    default:
                        break;
                }
            }

            return nCounter == sCounter && eCounter == wCounter;
        }
    }
}


// Algorithm is that there must be an equal ammount of S as N and E as W.