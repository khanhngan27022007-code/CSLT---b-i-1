using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai01_s5
    {

            static int TinhTong(int a, int b)
            {
                return a + b;
            }

            public static void Run()
            {
                // Truyền thẳng giá trị 5 và 10 vào hàm
                Console.WriteLine($"Tong hai so: {TinhTong(5, 10)}");
            }
        
    }
}

