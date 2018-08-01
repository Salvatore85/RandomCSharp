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

            string a = "abcd";
            string b = "bcda"; // bad daa a1b2c3 abc123

            string aa = String.Concat(a.OrderBy(c => c));
            string bb = String.Concat(b.OrderBy(c => c));

            if (aa == bb)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            var result = new List<string>();

            //foreach (var woordje in words)
            //{
            //    if (woordje == word)
            //    {
            //        result.Add(woordje);
            //    }
            //}
            
            var lettersToCheck = word.ToCharArray();

            foreach (var testWord in words)
            {
                if (testWord.Length == word.Length)
                {
                    var lettersToCompare = testWord.ToCharArray();

                    foreach (var letterToCompare in lettersToCompare)
                    {
                    }
                }
                else
                {
                    return result;
                }
                
            }

            return result;
        }
    }
}
