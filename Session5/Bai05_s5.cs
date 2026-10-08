using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai05_s5
    {
        static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Run()
        {
            string input = "Hello World";
            string output = DaoNguocChuoi(input);
            Console.WriteLine($"Input: \"{input}\" -> Output: \"{output}\"");
        }
    }
}
