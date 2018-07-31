using System;
using System.Text;

namespace DiamondBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe groot moet de diamant zijn: ");
            var size = Console.ReadLine();
            Console.WriteLine(Print(Convert.ToInt32(size)));


            Console.ReadLine();
        }

        //TESTED 
        public static string Print(int n)
        {
            string stars = "*";
            string space = " ";
            string spaces = "";
            var initSpaces = n / 2;
            var diamondBuilder = new StringBuilder();

            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            for (int i = 1; i < n; i++)
            {
                if (i == 1)
                {
                    for (int j = 0; j < initSpaces; j++)
                    {
                        spaces = spaces + space;
                    }

                    diamondBuilder.Append($"{spaces}{stars}\n");
                }

                if (stars.Length >= n)
                {
                    stars = stars.Remove(stars.Length - 2);
                    diamondBuilder.Append($"{space}{stars}\n");
                    break;
                }
                else
                {
                    stars += "**";
                    spaces = spaces.Remove(spaces.Length - 1);
                    diamondBuilder.Append($"{spaces}{stars}\n");
                }
            }

            spaces = " ";

            if (stars.Length <= n)
            {
                for (int i = 0; i < n; i++)
                {
                    spaces = spaces + space;

                    if (stars.Length >= 3)
                    {
                        stars = stars.Remove(stars.Length - 2);
                        diamondBuilder.Append($"{spaces}{stars}\n");
                    }
                }
            }

            return diamondBuilder.ToString();
        }
    }
}
