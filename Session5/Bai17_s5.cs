using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai17_s5
    {
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static void Run()
        {
            int a = 12, b = 18;
            Console.WriteLine($"Input: a = {a}, b = {b} -> Output: {UCLN(a, b)}");
        }
    }
}
