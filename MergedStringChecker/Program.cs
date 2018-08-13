using System;
using System.Linq;
using System.Text;

namespace MergedStringChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = " alv to e";
            string part2 = "s   a  r ";

            string combined = "salvatore";

            Console.WriteLine(isMerge(combined, part1, part2));

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
            string lettersToMerge = part2.Replace(" ", "");

            StringBuilder builder = new StringBuilder(s);

            int counter = spaceIndexes.Count;

            for (int i = 0; i < counter; i++)
            {
                builder[spaceIndexes[i]] = lettersToMerge[i];
                counter--;
            }

            if (builder.ToString() == s)
            {
                return true;
            }

            return false;
        }
    }
}
