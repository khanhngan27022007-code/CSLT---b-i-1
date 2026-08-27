using System;

namespace CSLT.Session3
{
    public enum CurrencyType
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4
    }

    public class Bai03_s3
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal tienVND;
            // Bắt lỗi nhập tiền VNĐ dùng while(true)
            while (true)
            {
                Console.Write("Nhập số tiền VNĐ: ");
                if (decimal.TryParse(Console.ReadLine(), out tienVND) && tienVND > 0)
                {
                    break; // Đúng điều kiện thì thoát khỏi vòng lặp
                }
                Console.WriteLine(" Số tiền không hợp lệ hoặc phải lớn hơn 0! Vui lòng nhập lại.\n");
            }

            int luaChon;
            // Bắt lỗi chọn ngoại tệ dùng while(true)
            while (true)
            {
                Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
                if (int.TryParse(Console.ReadLine(), out luaChon) && Enum.IsDefined(typeof(CurrencyType), luaChon))
                {
                    break; // Đúng lựa chọn từ 1 đến 4 thì thoát lặp
                }
                Console.WriteLine(" Lựa chọn không hợp lệ (chỉ nhập 1, 2, 3 hoặc 4)! Vui lòng nhập lại.\n");
            }

            CurrencyType loaiTien = (CurrencyType)luaChon;

            // Tính phí dịch vụ (0.5%) và tiền thực tế
            decimal phiDichVu = tienVND * 0.005m;
            decimal tienThucTe = tienVND - phiDichVu;

            // Xác định tỷ giá theo enum
            decimal tyGia = 0m;
            string donViTien = "";

            switch (loaiTien)
            {
                case CurrencyType.USD:
                    tyGia = 25400m;
                    donViTien = "USD";
                    break;
                case CurrencyType.EUR:
                    tyGia = 27200m;
                    donViTien = "EUR";
                    break;
                case CurrencyType.JPY:
                    tyGia = 165m;
                    donViTien = "JPY";
                    break;
                case CurrencyType.GBP:
                    tyGia = 32100m;
                    donViTien = "GBP";
                    break;
            }

            // Quy đổi tiền
            decimal tienNgoaiTe = tienThucTe / tyGia;

            // In kết quả
            Console.WriteLine($"\nPhí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {tienThucTe:N0} VNĐ");
            Console.WriteLine($"Số tiền {donViTien} nhận được: {tienNgoaiTe:N2} {donViTien}");
            Console.ReadLine();
        }
    }
}