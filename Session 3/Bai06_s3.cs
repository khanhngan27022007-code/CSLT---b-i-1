using System;
using System.Globalization; 
using System.Text;

namespace CSLT.Session3
{
    public class Bai06_s3
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string hoTenTho = "";

            while (true)
            {
                Console.Write("Nhập họ tên thô: ");
                hoTenTho = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(hoTenTho))
                {
                    break;
                }
                Console.WriteLine("Họ tên không được để trống! Vui lòng nhập lại.\n");
            }

            // Tách các từ và dọn dẹp khoảng trắng thừa
            string[] tuPhanBiet = hoTenTho.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Viết hoa chữ cái đầu bằng TextInfo
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            for (int i = 0; i < tuPhanBiet.Length; i++)
            {
                tuPhanBiet[i] = textInfo.ToTitleCase(tuPhanBiet[i].ToLower());
            }

            string hoTenChuan = string.Join(" ", tuPhanBiet);

            // Tách Họ, Tên, Tên Đệm
            string ho = tuPhanBiet[0];
            string ten = tuPhanBiet[tuPhanBiet.Length - 1];
            string tenDem = tuPhanBiet.Length > 2 ? string.Join(" ", tuPhanBiet, 1, tuPhanBiet.Length - 2) : "";

            // Tạo Username & Email
            string hoTenKhongDau = BoDauTiengViet(hoTenChuan).ToLower();
            string[] tuKhongDau = hoTenKhongDau.Split(' ');

            string tenKD = tuKhongDau[tuKhongDau.Length - 1];
            string hoKD = tuKhongDau[0];
            string tenDemKD = tuKhongDau.Length > 2 ? string.Join("", tuKhongDau, 1, tuKhongDau.Length - 2) : "";

            string username = $"{tenKD}.{hoKD}{tenDemKD}";
            string email = $"{username}@company.edu.vn";

            // In kết quả
            Console.WriteLine($"\nHọ tên chuẩn hóa: {hoTenChuan}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {(string.IsNullOrEmpty(tenDem) ? "Không có" : tenDem)} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");

            Console.ReadLine();
        }

        private static string BoDauTiengViet(string str)
        {
            string normalized = str.Normalize(NormalizationForm.FormD);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (char c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC).Replace('đ', 'd').Replace('Đ', 'D');
        }
    }
}