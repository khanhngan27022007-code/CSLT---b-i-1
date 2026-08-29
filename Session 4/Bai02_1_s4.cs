using System;

namespace CSLT.Session4
{
    public class Bai02_1_s4
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(" BÀI 2.1: KIỂM TRA SỐ CHẴN HAY LẺ ");
            Console.Write("Nhập một số nguyên: ");
            int num = int.Parse(Console.ReadLine() ! );

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{num} là số lẻ.");
            }

            Console.ReadLine();
        }
    }
}