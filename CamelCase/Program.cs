using System;
using System.Linq;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string Test = "some test string";

            Console.WriteLine(CamelCase(Test));

            Console.ReadLine();
        }

        public static string CamelCase(string str)
        {
            string CleanSentence = "";
            string[] words = str.Split(" ");

            foreach (string word in words)
            {
                string transmorph = word.First().ToString().ToUpper() + word.Substring(1);
                CleanSentence += transmorph;
            }

            return CleanSentence;
        }
    }
}
