using System;
using System.Linq;

namespace MergedStringChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //string part1 = "s lva  re";
            //string part2 = " a   to  ";

            //string combined = "salvatore";

            //Console.WriteLine(isMerge(combined, part1, part2));

            string test = "Salvatore";

            foreach (var letter in test)
            {
                Console.WriteLine(letter);
            }
            Console.ReadLine();
        }

        public static bool isMerge(string s, string part1, string part2)
        {
            if (part1.Length + part2.Length != s.Length * 2 )
            {
                return false;
            }

            return false;
        }
    }
}
