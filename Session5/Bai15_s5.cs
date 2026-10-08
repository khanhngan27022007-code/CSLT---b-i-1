using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai15_s5
    {
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Run()
        {
            int[] arr = { 3, 1, 4, 2 };
            Console.Write("Input: [3, 1, 4, 2] -> Output: ");
            SapXepMang(arr);
        }
    }
}
