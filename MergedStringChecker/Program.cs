using System;
using System.Linq;
using System.Text;

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

            StringBuilder sbuilder = new StringBuilder(test);

            char newchar = 'a';

            sbuilder[3] = newchar; 

            Console.WriteLine(sbuilder.ToString());

            Console.ReadLine();
        }

        public static bool isMerge(string s, string part1, string part2)
        {
            //Check of sizes of the strings are equal
            if (part1.Length + part2.Length != s.Length * 2 )
            {
                return false;
            }

            //Get the indexes of the spaces in part1
            var spaceIndexes = part1.ToCharArray()
                .Select((v, i) => new { value = v, index = i })
                .Where(element => element.value == ' ')
                .Select((element => element.index))
                .ToList();

            //Remove spaces from part2
            string trimmedPart2 = part2.Replace(" ", "");

            StringBuilder builder = new StringBuilder(s);

            int counter = spaceIndexes.Count;

            //foreach (var VARIABLE in COLLECTION)
            //{
            //    builder[index#] = trimmedpart2[index#]
            //    counter--; 
            //}

            if (builder.ToString() == s)
            {
                return true;
            }

            return false;
        }
    }
}
