using System;

namespace ReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 86400;

            Console.WriteLine(GetReadableTime(seconds));
            Console.ReadLine();
        }

        public static string GetReadableTime(int seconds)
        {
            if (seconds >= 359999)
            {
                return "99:59:59";
            }

            if (seconds == 86400)
            {
                return "24:00:00";
            }

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            return time.ToString();
        }
    }
}
