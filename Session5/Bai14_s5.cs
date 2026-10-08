using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai14_s5
    {
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public static void Run()
        {
            int n = 1234;
            Console.WriteLine($"Input: {n} -> Output: {TongCacChuSo(n)}");
        }
    }
}
