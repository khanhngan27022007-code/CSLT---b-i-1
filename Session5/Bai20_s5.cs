using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai20_s5
    {
        static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            string[] words = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static void Run()
        {
            string sentence = "Học lập trình C# rất thú vị";
            Console.WriteLine($"Input: \"{sentence}\" -> Output: {DemSoTu(sentence)}");
        }
    }
}
