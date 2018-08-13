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
            TimeSpan time = TimeSpan.FromSeconds(seconds);

            return string.Format($"{(int)time.TotalHours:00}:{time.Minutes:00}:{time.Seconds:00}");
        }
    }
}
