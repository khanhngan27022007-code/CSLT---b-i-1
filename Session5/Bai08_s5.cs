using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai08_s5
    {
        static int DemNguyenAm(string s)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static void Run()
        {
            string s = "Hello World";
            Console.WriteLine($"Input: \"{s}\" -> Output: {DemNguyenAm(s)}");
        }
    }
}
