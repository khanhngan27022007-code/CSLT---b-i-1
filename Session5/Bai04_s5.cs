using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session5
{
    public class Bai04_s5
    {
        static long TinhGiaiThua(int n)
        {
            long kq = 1; // Biến lưu kết quả khởi tạo bằng 1
            for (int i = 1; i <= n; i++)
            {
                kq *= i; // Nhân dồn vào biến kết quả
            }
            return kq;
        }

        public static void Run()
        {
            int n = 5; // Tính 5!
            long giaiThua = TinhGiaiThua(n);
            Console.WriteLine($"{n}! = {giaiThua}");
        }

    }
}
