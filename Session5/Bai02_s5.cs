using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai02_s5
    {
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        public static void Run()
        {
            int n = 4; // Ví dụ kiểm tra số 4
            if (KiemTraChan(n))
                Console.WriteLine($"{n} la so chan");
            else
                Console.WriteLine($"{n} la so le");
        }
    }
}
    

