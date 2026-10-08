using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai03_s5
    {
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static void Run()
        {
            int max = TimMax(12, 45, 23); // Truyền vào 3 số cụ thể
            Console.WriteLine($"So lon nhat la: {max}");
        }
    }
}
