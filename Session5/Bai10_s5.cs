using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai10_s5
    {
        static double TinhTrungBinh(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }

        public static void Run()
        {
            int[] arr = { 4, 5, 6, 7 };
            Console.WriteLine($"Input: [4, 5, 6, 7] -> Output: {TinhTrungBinh(arr)}");
        }
    }
}
