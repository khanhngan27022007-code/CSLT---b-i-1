namespace CSLT.Session3
{
    public class Bai01_s3
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal a, b;

            // 1. Chặn chỉ số cũ (phải là số và >= 0)
            while (true)
            {
                Console.Write("Nhập chỉ số điện cũ (kWh): ");
                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out a))
                {
                    Console.WriteLine("Lỗi: Định dạng không hợp lệ! Vui lòng chỉ nhập số.");
                }
                else if (a < 0)
                {
                    Console.WriteLine("Lỗi: Chỉ số điện không được là số âm. Vui lòng nhập lại!");
                }
                else
                {
                    break; // Dữ liệu đúng thì thoát vòng lặp
                }
            }

            // 2. Chặn chỉ số mới (phải là số và >= chỉ số cũ)
            while (true)
            {
                Console.Write("Nhập chỉ số điện mới (kWh): ");
                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out b))
                {
                    Console.WriteLine("Lỗi: Định dạng không hợp lệ! Vui lòng chỉ nhập số.");
                }
                else if (b < a)
                {
                    Console.WriteLine("Lỗi: Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ. Vui lòng nhập lại!");
                }
                else
                {
                    break; // Dữ liệu đúng thì thoát vòng lặp
                }
            }

            // --- GIỮ NGUYÊN PHẦN TÍNH TOÁN CỦA CẬU BÊN DƯỚI ---
            decimal c = b - a;
            decimal l = 0;

            if (c <= 50)
            {
                l = c * 1806m;
            }
            else if (c <= 100)
            {
                l = (50 * 1806m) + (c - 50) * 1866m;
            }
            else if (c <= 200)
            {
                l = (50 * 1806m) + (50 * 1866m) + (c - 100) * 2167m;
            }
            else if (c <= 300)
            {
                l = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (c - 200) * 2729m;
            }
            else
            {
                l = (50 * 1806m) + (50 * 1866m) + (100 * 2167m) + (100 * 2729m) + (c - 300) * 3050m;
            }

            decimal vat = Math.Round(l * 0.08m); 
            decimal tongtien = l + vat;

            Console.WriteLine("\n--- HÓA ĐƠN TIỀN ĐIỆN ---");
            Console.WriteLine($"Số điện tiêu thụ: {c} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {l:#,##0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {vat:#,##0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongtien:#,##0} VNĐ");
            Console.ReadLine();
        }
    }
}