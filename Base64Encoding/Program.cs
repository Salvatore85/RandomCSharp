using System;
using System.Text;

namespace Base64Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringTest = "Salvatore";
            var base64Test = "dGhpcyBpcyBhIHN0cmluZyEh";

            Console.WriteLine(ToBase64(stringTest));

            Console.ReadLine();
        }

        public static string ToBase64(string s)
        {
            var sBytes = Encoding.UTF8.GetBytes(s);
            return Convert.ToBase64String(sBytes);
        }

        public static string FromBase64(string s)
        {
            var base64Bytes = Convert.FromBase64String(s);
            return Encoding.UTF8.GetString(base64Bytes);
        }
    }
}
