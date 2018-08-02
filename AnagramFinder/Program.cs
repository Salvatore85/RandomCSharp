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

            string aa = string.Concat(a.OrderBy(c => c));
            string bb = String.Concat(b.OrderBy(c => c));

            Console.WriteLine(aa == bb ? "YES" : "NO");

            Console.ReadLine();
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            var result = new List<string>();

            foreach (var checkWord in words)
            {
                string inputWord = string.Concat(word.OrderBy(o => o));
                string wordToCompare = string.Concat(checkWord.OrderBy(o => o));

                if (inputWord == wordToCompare)
                {
                    result.Add(checkWord);
                }
            }

            //foreach (var woordje in words)
            //{
            //    if (woordje == word)
            //    {
            //        result.Add(woordje);
            //    }
            //}
            
            //var lettersToCheck = word.ToCharArray();

            //foreach (var testWord in words)
            //{
            //    if (testWord.Length == word.Length)
            //    {
            //        var lettersToCompare = testWord.ToCharArray();

            //        foreach (var letterToCompare in lettersToCompare)
            //        {
            //        }
            //    }
            //    else
            //    {
            //        return result;
            //    }
                
            //}

            return result;
        }
    }
}
