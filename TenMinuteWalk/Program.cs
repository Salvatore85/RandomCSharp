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
            if (walk.Length != 10)
            {
                return false;
            }

            return true;
        }
    }
}
