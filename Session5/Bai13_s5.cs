using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5 
{
    public class Bai13_s5
    {
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        public static void Run()
        {
            int[] arr = { 10, 5, 8, 2, 9 };
            Console.WriteLine($"Input: [10, 5, 8, 2, 9] -> Output: {TimMin(arr)}");
        }
    }
}
