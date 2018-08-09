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

            string test = "Sal vat ore";

            var spaces = test.ToCharArray()
                .Select((v, i) => new {value = v, index = i})
                .Where(element => element.value == ' ')
                .Select((element => element.index))
                .ToList();

            foreach (var space in spaces)
            {
                Console.WriteLine(space);
            }

            Console.ReadLine();
        }

        public static bool isMerge(string s, string part1, string part2)
        {
            if (part1.Length + part2.Length != s.Length * 2 )
            {
                return false;
            }

            var newPart1 = part1.ToList();
            var newPart2 = part2.ToList();

            var spaces = s.ToCharArray()
                .Select((v, i) => new { value = v, index = i })
                .Where(element => element.value == ' ')
                .Select((element => element.index))
                .ToList();


            return false;
        }
    }
}
