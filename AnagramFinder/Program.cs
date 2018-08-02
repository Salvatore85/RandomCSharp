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

            var result = Anagrams2(test, testList);

            foreach (var words in result)
            {
                Console.WriteLine(words);
            }

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

            return result;
        }

        public static List<string> Anagrams2(string word, List<string> words)
        {
            return words?.Where(w => w.OrderBy(c => c).SequenceEqual(word.OrderBy(c => c))).ToList();
        }
    }
}
