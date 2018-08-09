using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};

            var newArray = MoveZeroes(test);

            foreach (var number in newArray)
            {
                Console.Write(number);
            }

            Console.ReadLine();
        }

        public static int[] MoveZeroes(int[] arr)
        {
            //var result = new List<int>();
            //int zeroCounter = 0;

            //foreach (var number in arr)
            //{
            //    if (number != 0)
            //    {
            //        result.Add(number);
            //    }
            //    else
            //    {
            //        zeroCounter++;
            //    }
            //}

            //for (int i = 0; i < zeroCounter; i++)
            //{
            //    result.Add(0);
            //}

            //return result.ToArray();

            return arr.OrderBy(x => x==0).ToArray();
        }
    }
}
