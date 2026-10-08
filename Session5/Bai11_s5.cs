using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai11_s5
    {
        static bool KiemTraDoiXung(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;
        }

        public static void Run()
        {
            Console.WriteLine($"Input: \"radar\" -> Output: {KiemTraDoiXung("radar")}");
            Console.WriteLine($"Input: \"hello\" -> Output: {KiemTraDoiXung("hello")}");
        }
    }
}
