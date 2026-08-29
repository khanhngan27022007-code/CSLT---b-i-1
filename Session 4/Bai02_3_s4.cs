using System;

namespace CSLT.Session4
{
    public class Bai02_3_s4
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(" BÀI 2.3: KIỂM TRA LOẠI TAM GIÁC ");
            
            Console.Write("Nhập cạnh a: ");
            double a = double.Parse(Console.ReadLine()!);
            
            Console.Write("Nhập cạnh b: ");
            double b = double.Parse(Console.ReadLine()!);
            
            Console.Write("Nhập cạnh c: ");
            double c = double.Parse(Console.ReadLine()!);

            // Kiểm tra điều kiện tạo thành 1 tam giác hợp lệ
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Đây là tam giác đều");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Đây là tam giác cân");
                else
                    Console.WriteLine("Đây là tam giác thường");
            }
            else
            {
                Console.WriteLine("Ba độ dài trên không tạo thành tam giác hợp lệ.");
            }

            Console.ReadLine();
        }
    }
}