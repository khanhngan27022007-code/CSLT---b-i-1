using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai18_s5
    {
        static string DecimalToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }

        public static void Run()
        {
            int n = 10;
            Console.WriteLine($"Input: {n} -> Output: \"{DecimalToBinary(n)}\"");
        }
    }
}
