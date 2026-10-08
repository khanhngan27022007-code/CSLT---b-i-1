using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai16_s5
    {
        static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }

        public static void Run()
        {
            string s = "programming";
            Console.WriteLine($"Input: \"{s}\" -> Output: \"{XoaTrungLap(s)}\"");
        }
    }
}
