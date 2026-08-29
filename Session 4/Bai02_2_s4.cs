using System;

namespace CSLT.Session4
{
    public class Bai02_2_s4
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== BÀI 2.2: TÌM SỐ LỚN NHẤT TRONG 3 SỐ ===");
            Console.Write("Input 1st number: ");
            int n1 = int.Parse(Console.ReadLine() ! );
            Console.Write("Input 2nd number: ");
            int n2 = int.Parse(Console.ReadLine() ! );
            Console.Write("Input 3rd number: ");
            int n3 = int.Parse(Console.ReadLine() ! );

            int max = n1;
            if (n2 > max) max = n2;
            if (n3 > max) max = n3;

            Console.WriteLine($"\nThe 1st Number = {n1},\tThe 2nd Number = {n2},\tThe 3rd Number = {n3}");
            Console.WriteLine($"The {max} is the greatest among three.");

            Console.ReadLine();
        }
    }
}