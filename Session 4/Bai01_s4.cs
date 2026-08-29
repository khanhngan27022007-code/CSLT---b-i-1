using System;

namespace CSLT.Session4
{
    public class Bai01_s4
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== GIẢI VÀ BIỆN LUẬN PHƯƠNG TRÌNH BẬC 2 (ax² + bx + c = 0) ===");

            // 1. Nhập hệ số a
            double a;
            while (true)
            {
                Console.Write("Nhập hệ số a: ");
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    break;
                }
                Console.WriteLine("Hệ số a phải là một số thực! Vui lòng nhập lại.\n");
            }

            // 2. Nhập hệ số b
            double b;
            while (true)
            {
                Console.Write("Nhập hệ số b: ");
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    break;
                }
                Console.WriteLine("Hệ số b phải là một số thực! Vui lòng nhập lại.\n");
            }

            // 3. Nhập hệ số c
            double c;
            while (true)
            {
                Console.Write("Nhập hệ số c: ");
                if (double.TryParse(Console.ReadLine(), out c))
                {
                    break;
                }
                Console.WriteLine("Hệ số c phải là một số thực! Vui lòng nhập lại.\n");
            }

            // --- GIẢI VÀ BIỆN LUẬN ---
            if (a == 0)
            {
                // Phương trình trở thành phương trình bậc nhất bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("\nPhương trình có vô số nghiệm.");
                    }
                    else
                    {
                        Console.WriteLine("\nPhương trình vô nghiệm.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"\nPhương trình là bậc nhất, có 1 nghiệm duy nhất: x = {x:F2}");
                }
            }
            else
            {
                // Phương trình bậc hai ax² + bx + c = 0
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("\nPhương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"\nPhương trình có nghiệm kép: x1 = x2 = {x:F2}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("\nPhương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine($"x1 = {x1:F2}");
                    Console.WriteLine($"x2 = {x2:F2}");
                }
            }

            Console.ReadLine();
        }
    }
}