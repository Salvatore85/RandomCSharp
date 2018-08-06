using System;
using System.Collections.Generic;
using System.Linq;

//Splits a string into pairs of two characters.
namespace StringSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string TestString = "abcdefgasdadfasdfasdfasdfadfasdfakasdklfaskldfjklajsdfklajkldfjakldfjklajkldfaujhgsdfasd";
            string test = TestString.Remove(0, 2);

            var outcome = Splitter(TestString);

            foreach (var word in outcome)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }

        public static string[] Splitter(string str)
        {
            var result = new List<string>();
            string remainder = str;

            while (remainder.Length > 0)
            {
                result.Add(remainder.Substring(0, 2));
                remainder = remainder.Remove(0, 2);
                if (remainder.Length == 1)
                {
                    remainder = remainder + "_";
                    result.Add(remainder);
                    break;
                }
            }

            return result.ToArray();
        }
    }
}
