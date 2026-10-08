using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai19_s5
    {
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        public static void Run()
        {
            Console.WriteLine($"Input: 2024 -> Output: {KiemTraNamNhuan(2024)}");
            Console.WriteLine($"Input: 2023 -> Output: {KiemTraNamNhuan(2023)}");
        }
    }
}
