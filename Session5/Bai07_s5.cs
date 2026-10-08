using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai07_s5
    {
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static void Run()
        {
            Console.WriteLine($"Input: 7 -> Output: {KiemTraNguyenTo(7)}");
            Console.WriteLine($"Input: 10 -> Output: {KiemTraNguyenTo(10)}");
        }
    }
}
