using System;

namespace CSLT.Session4
{
    public class Bai02_4_s4
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== BÀI 2.4: XÁC ĐỊNH GÓC PHẦN TƯ TỌA ĐỘ ===");
            Console.Write("Nhập tọa độ X: ");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập tọa độ Y: ");
            int y = int.Parse(Console.ReadLine()!);

            if (x > 0 && y > 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) thuộc Góc phần tư thứ I (First quadrant).");
            else if (x < 0 && y > 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) thuộc Góc phần tư thứ II (Second quadrant).");
            else if (x < 0 && y < 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) thuộc Góc phần tư thứ III (Third quadrant).");
            else if (x > 0 && y < 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) thuộc Góc phần tư thứ IV (Fourth quadrant).");
            else
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên gốc tọa độ hoặc trên trục tọa độ.");

            Console.ReadLine();
        }
    }
}