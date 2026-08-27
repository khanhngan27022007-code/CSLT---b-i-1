namespace CSLT.Session3
{
    public class Bai02_s3
    {
        public static void Run()
        {
            // Để hiển thị tiếng Việt có dấu trong Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double chieucao, cannang;

            // 1. Nhập và kiểm tra Chiều cao (phải là số và > 0)
            while (true)
            {
                Console.Write("Chiều cao (m): ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out chieucao))
                {
                    Console.WriteLine("Lỗi: Định dạng không hợp lệ! Vui lòng nhập số.");
                }
                else if (chieucao <= 0)
                {
                    Console.WriteLine("Lỗi: Chiều cao phải lớn hơn 0 (ví dụ: 1.68). Vui lòng nhập lại!");
                }
                else
                {
                    break; // Nhập đúng thì thoát vòng lặp
                }
            }

            // 2. Nhập và kiểm tra Cân nặng (phải là số và > 0)
            while (true)
            {
                Console.Write("Cân nặng (kg): ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out cannang))
                {
                    Console.WriteLine("Lỗi: Định dạng không hợp lệ! Vui lòng nhập số.");
                }
                else if (cannang <= 0)
                {
                    Console.WriteLine("Lỗi: Cân nặng phải lớn hơn 0 (ví dụ: 65.5). Vui lòng nhập lại!");
                }
                else
                {
                    break; // Nhập đúng thì thoát vòng lặp
                }
            }

            // 3. Tính chỉ số BMI
            double bmi = cannang / (chieucao * chieucao);

            // 4. Phân loại sức khỏe theo chuẩn WHO dành cho người châu Á
            string phanloai = "";
            if (bmi < 18.5)
            {
                phanloai = "Gầy (Thiếu cân)";
            }
            else if (bmi < 23.0)
            {
                phanloai = "Bình thường (Lý tưởng)";
            }
            else if (bmi < 25.0)
            {
                phanloai = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                phanloai = "Béo phì";
            }

            // 5. Tính dải cân nặng lý tưởng
            double cannangMin = 18.5 * (chieucao * chieucao);
            double cannangMax = 22.9 * (chieucao * chieucao);

            // 6. In kết quả 
            Console.WriteLine($"\nChỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanloai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {cannangMin:F2} kg đến {cannangMax:F2} kg.");
            Console.ReadLine();
        }
    }
}