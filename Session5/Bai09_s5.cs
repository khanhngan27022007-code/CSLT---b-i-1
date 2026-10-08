using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai09_s5
    {
        static double TinhLuyThua(double x, int y)
        {
            double result = 1.0;
            for (int i = 0; i < Math.Abs(y); i++)
            {
                result *= x;
            }
            return y < 0 ? 1.0 / result : result;
        }

        public static void Run()
        {
            double x = 2;
            int y = 3;
            Console.WriteLine($"Input: x = {x}, y = {y} -> Output: {TinhLuyThua(x, y)}");
        }
    }
}
