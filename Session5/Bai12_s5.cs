using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5 
{
    public class Bai12_s5
    {
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        public static void Run()
        {
            double c = 25;
            Console.WriteLine($"Input: {c} -> Output: {CelsiusToFahrenheit(c)}");
        }
    }
}
