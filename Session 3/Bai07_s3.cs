using System;

namespace CSLT.Session3
{
    public class Bai07_s3
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double quangDuong;
            // 1. Nhập quãng đường (km) > 0
            while (true)
            {
                Console.Write("Quãng đường (km): ");
                if (double.TryParse(Console.ReadLine(), out quangDuong) && quangDuong > 0)
                {
                    break;
                }
                Console.WriteLine("Quãng đường phải là số lớn hơn 0! Vui lòng nhập lại.\n");
            }

            double mucTieuThu;
            // 2. Nhập mức tiêu thụ nhiên liệu (lít/100km) > 0
            while (true)
            {
                Console.Write("Mức tiêu hao (L/100km): ");
                if (double.TryParse(Console.ReadLine(), out mucTieuThu) && mucTieuThu > 0)
                {
                    break;
                }
                Console.WriteLine("Mức tiêu hao phải là số lớn hơn 0! Vui lòng nhập lại.\n");
            }

            decimal giaXang;
            // 3. Nhập giá xăng (VNĐ/lít) > 0 (dùng decimal cho tiền tệ)
            while (true)
            {
                Console.Write("Giá xăng (VNĐ/Lít): ");
                if (decimal.TryParse(Console.ReadLine(), out giaXang) && giaXang > 0)
                {
                    break;
                }
                Console.WriteLine("Giá xăng phải là số lớn hơn 0! Vui lòng nhập lại.\n");
            }

            int soNguoi;
            // 4. Nhập số người đi (người) >= 1
            while (true)
            {
                Console.Write("Số người đi: ");
                if (int.TryParse(Console.ReadLine(), out soNguoi) && soNguoi >= 1)
                {
                    break;
                }
                Console.WriteLine("Số người phải là số nguyên từ 1 trở lên! Vui lòng nhập lại.\n");
            }

            // --- TÍNH TOÁN ---
            // Tổng số lít xăng = (Quãng đường / 100) * Mức tiêu thụ
            double tongLitXang = (quangDuong / 100.0) * mucTieuThu;

            // Tổng chi phí = Tổng lít xăng * Giá xăng (Ép kiểu double -> decimal)
            decimal tongChiPhi = (decimal)tongLitXang * giaXang;

            // Chi phí mỗi người = Chi phí trung bình làm tròn LÊN hàng nghìn VNĐ gần nhất
            decimal chiPhiMoiNguoiThuc = tongChiPhi / soNguoi;
            // Chia cho 1000 -> Làm tròn lên bằng Math.Ceiling -> Nhân lại 1000
            decimal chiPhiMoiNguoi = Math.Ceiling(chiPhiMoiNguoiThuc / 1000m) * 1000m;

            // --- IN KẾT QUẢ ---
            Console.WriteLine($"\nTổng nhiên liệu tiêu thụ: {tongLitXang:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VNĐ");
            Console.WriteLine($"Chi phí mỗi người: {chiPhiMoiNguoi:N0} VNĐ");

            Console.ReadLine();
        }
    }
}