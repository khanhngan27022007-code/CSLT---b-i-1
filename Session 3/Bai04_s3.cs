using System;
using System.Globalization;

namespace CSLT.Session3
{
    public class Bai04_s3
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DateTime ngaysinh;

            // Bắt lỗi nhập ngày sinh dùng while (true)
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string input = Console.ReadLine();

                // Kiểm tra đúng định dạng dd/MM/yyyy
                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                {
                    // Kiểm tra thêm điều kiện ngày sinh không được lớn hơn ngày hiện tại
                    if (ngaysinh <= DateTime.Today)
                    {
                        break; // Nhập đúng và hợp lệ thì thoát vòng lặp
                    }
                    Console.WriteLine(" Ngày sinh không thể lớn hơn ngày hiện tại! Vui lòng nhập lại.\n");
                }
                else
                {
                    Console.WriteLine(" Định dạng không hợp lệ! Vui lòng nhập đúng dạng dd/MM/yyyy (ví dụ: 25/10/2002).\n");
                }
            }

            // Lấy ngày hiện tại
            DateTime homnay = DateTime.Today;

            // Tính tuổi
            int tuoi = homnay.Year - ngaysinh.Year;
            if (homnay < ngaysinh.AddYears(tuoi))
            {
                tuoi--;
            }

            // Tính tổng số ngày đã sống
            TimeSpan ngaydasong = homnay - ngaysinh;

            // Tính sinh nhật tiếp theo
            DateTime nextsinhnhat = new DateTime(homnay.Year, ngaysinh.Month, ngaysinh.Day);
            if (nextsinhnhat < homnay)
            {
                nextsinhnhat = nextsinhnhat.AddYears(1);
            }

            int songay = (nextsinhnhat - homnay).Days;

            // In kết quả
            Console.WriteLine($"\nTuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {ngaydasong.TotalDays:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {songay} ngày nữa");
            Console.ReadLine();
        }
    }
}