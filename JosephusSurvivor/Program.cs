using System;
using System.Collections.Generic;

namespace JosephusSurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JosSurvivor(7, 3));
            Console.ReadLine();
        }

        public static int JosSurvivor(int n, int k)
        {
            var people = new List<int>();
            int removeStep = k - 1;

            for (int i = 0; i < n; i++)
            {
                people.Add(i+1);
            }

            if (people.Count == 2)
            {
                return people[1];
            }

            for (int i = 0; i < people.Count; i++)
            {
                if (removeStep > people.Count)
                {
                    removeStep = removeStep - n;
                }

                people.RemoveAt(removeStep);
                removeStep = removeStep + k;
            }

            return people[0];
        }
    }
}
