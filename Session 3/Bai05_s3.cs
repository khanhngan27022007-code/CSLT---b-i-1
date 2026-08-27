namespace CSLT.Session3
{
    public class Bai05_s3
    {
        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Nhập môn Csharp:
            Console.Write("Nhập số tín chỉ môn C#: ");
            int tcCsharp = int.Parse(Console.ReadLine());

            Console.Write($"C# {tcCsharp} TC: ");
            double diemCsharp = double.Parse(Console.ReadLine());

            //Nhập môn Toán:
            Console.Write("Nhập số tín chỉ môn Toán: ");
            int tcToan = int.Parse(Console.ReadLine());

            Console.Write($"Toán {tcToan} TC: ");
            double diemToan = double.Parse(Console.ReadLine());

            //Nhập môn Tiếng Anh:
            Console.Write("Nhập số tín chỉ môn Tiếng Anh: ");
            int tcTAnh = int.Parse(Console.ReadLine());

            Console.Write($"Toán {tcTAnh} TC: ");
            double diemTAnh = double.Parse(Console.ReadLine());

            int tongtc = tcCsharp + tcTAnh + tcToan;
            
            //Tính điểm trung bình
            double dtb = (diemCsharp * tcCsharp + diemTAnh * tcTAnh + diemToan * tcToan) / tongtc;

            // --- 3. QUY ĐỔI ĐIỂM CHỮ, GPA THANG 4 VÀ XẾP LOẠI ---
            char diemChu;
            double gpaThang4;
            string xepLoai;

            if (dtb >= 8.5)
            {
                diemChu = 'A';
                gpaThang4 = 4.0;
                xepLoai = "Xuất sắc / Giỏi";
            }
            else if (dtb >= 7.0)
            {
                diemChu = 'B';
                gpaThang4 = 3.0;
                xepLoai = "Khá";
            }
            else if (dtb >= 5.5)
            {
                diemChu = 'C';
                gpaThang4 = 2.0;
                xepLoai = "Trung bình";
            }
            else if (dtb >= 4.0)
            {
                diemChu = 'D';
                gpaThang4 = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = 'F';
                gpaThang4 = 0.0;
                xepLoai = "Kém (Trượt)";
            }

        // --- 4. IN KẾT QUẢ (OUTPUT) ---
            Console.WriteLine("\nOUTPUT");
            Console.WriteLine($"Điểm TB Thang 10: {dtb:F2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpaThang4:F1}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
            Console.ReadLine();
        }
    }
}
        

        