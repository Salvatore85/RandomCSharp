using System;
using System.ComponentModel;
using System.Linq;

namespace RomanNumeralsEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = ConvertNumber(2018);

            Console.WriteLine(number);
            Console.ReadLine();
        }

        public static string ConvertNumber(int n)
        {
            string[] thou = { "", "M", "MM", "MMM" };
            string[] hun  = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten  = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string roman = "";

            roman += thou[(int)(n / 1000) % 10];
            roman += hun[(int)(n / 100) % 10];
            roman += ten[(int)(n / 10) % 10];
            roman += ones[n % 10];

            return roman;
        }
    }
}
