using System;
using System.Linq;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "some test string";

            Console.WriteLine(CamelCase(test));

            Console.ReadLine();
        }

        public static string CamelCase(string str)
        {
            string cleanSentence = "";
            string[] words = str.Split(" ");

            foreach (string word in words)
            {
                string transmorph = word.First().ToString().ToUpper() + word.Substring(1);
                cleanSentence += transmorph;
            }

            return cleanSentence;
        }
    }
}
