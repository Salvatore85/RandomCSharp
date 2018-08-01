using System;
using System.Collections.Generic;
using System.Linq;

namespace AnagramFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "test";
            var testList = new List<string> {"sett", "ttes", "mest", "best", "test"};

            var result = Anagrams(test, testList);

            foreach (var words in result)
            {
                Console.WriteLine(words);
            }

            Console.ReadLine();
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            var testList = new List<string> { "sett", "ttes", "mest", "best", "test" };
            var result = new List<string>();

            foreach (var woordje in testList)
            {
                if (woordje == word)
                {
                    result.Add(woordje);
                }
            }

            return result;
        }
    }
}
