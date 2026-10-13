using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSLT.Session8
{
    public class Bai01_s8
    {
        // Hàm tổng để gọi khi cần chạy tất cả hoặc gọi từng bài
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Chạy toàn bộ bài tập Session 8");
            Bai02();
            
        }

        // 1. Tạo một file trống trên đĩa
        public static void Bai01()
        {
            string path = "test1.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                Console.WriteLine("Bài 1: Đã tạo file trống thành công!");
            }
        }

        // 2. Xóa một file khỏi đĩa
        public static void Bai02()
        {
            string path = "test1.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Bài 2: Đã xóa file thành công!");
            }
            else
            {
                Console.WriteLine("Bài 2: File không tồn tại.");
            }
        }

        // 3. Tạo file và ghi thêm một số đoạn text vào
        public static void Bai03()
        {
            string path = "test3.txt";
            File.WriteAllText(path, "Xin chào, đây là nội dung văn bản!");
            Console.WriteLine("Bài 3: Đã tạo file và ghi text thành công!");
        }

        // 4. Tạo file văn bản và đọc nội dung lên màn hình
        public static void Bai04()
        {
            string path = "test3.txt";
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("Bài 4: Nội dung file:\n" + content);
            }
        }

        // 5. Tạo file và ghi một mảng các chuỗi vào file
        public static void Bai05()
        {
            string path = "test5.txt";
            string[] lines = { "Dòng 1: Chúc Woo học tốt", "Dòng 2: Môn C# Data Science", "Dòng 3: UEH" };
            File.WriteAllLines(path, lines);
            Console.WriteLine("Bài 5: Đã ghi mảng chuỗi vào file thành công!");
        }

        // 6. Nối thêm text vào một file đã tồn tại
        public static void Bai06()
        {
            string path = "test5.txt";
            string appendText = "\nDòng 4: Nội dung nối thêm.";
            File.AppendAllText(path, appendText);
            Console.WriteLine("Bài 6: Đã append text vào file thành công!");
        }

        // 7. Tạo file, copy thành file khác với tên mới và hiển thị nội dung
        public static void Bai07()
        {
            string sourcePath = "test3.txt";
            string destPath = "test3_copy.txt";

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destPath, true);
                Console.WriteLine("Bài 7: Nội dung file copy:");
                Console.WriteLine(File.ReadAllText(destPath));
            }
        }

        // 8. Tạo file và di chuyển nó vào cùng thư mục với tên khác (Đổi tên file)
        public static void Bai08()
        {
            string sourcePath = "test1.txt";
            if (!File.Exists(sourcePath)) File.WriteAllText(sourcePath, "Test move");

            string destPath = "test1_moved.txt";
            if (File.Exists(destPath)) File.Delete(destPath);

            File.Move(sourcePath, destPath);
            Console.WriteLine("Bài 8: Đã di chuyển và đổi tên file thành công!");
        }

        // 9. Đọc dòng đầu tiên của file
        public static void Bai09()
        {
            string path = "test5.txt";
            if (File.Exists(path))
            {
                string firstLine = File.ReadLines(path).First();
                Console.WriteLine("Bài 9: Dòng đầu tiên: " + firstLine);
            }
        }

        // 10. Tạo và đọc dòng cuối cùng của file
        public static void Bai10()
        {
            string path = "test5.txt";
            if (File.Exists(path))
            {
                string lastLine = File.ReadLines(path).Last();
                Console.WriteLine("Bài 10: Dòng cuối cùng: " + lastLine);
            }
        }

        // 11. Tạo và đọc n dòng cuối của file (Ví dụ lấy 2 dòng cuối)
        public static void Bai11()
        {
            string path = "test5.txt";
            int n = 2;
            if (File.Exists(path))
            {
                var lastNLines = File.ReadLines(path).TakeLast(n);
                Console.WriteLine($"Bài 11:  {n} dòng cuối cùng");
                foreach (var line in lastNLines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // 12. Đọc một dòng cụ thể từ file (Ví dụ đọc dòng số 2, index 1)
        public static void Bai12()
        {
            string path = "test5.txt";
            int lineNumber = 1; // Dòng thứ 2
            if (File.Exists(path))
            {
                string specificLine = File.ReadLines(path).ElementAtOrDefault(lineNumber);
                Console.WriteLine($"Bài 12: Nội dung dòng {lineNumber + 1}: {specificLine}");
            }
        }

        // 13. Đếm số lượng dòng trong file
        public static void Bai13()
        {
            string path = "test5.txt";
            if (File.Exists(path))
            {
                int lineCount = File.ReadLines(path).Count();
                Console.WriteLine($"Bài 13: Tổng số dòng trong file: {lineCount}");
            }
        }

        // 14. In cấu trúc của một thư mục cụ thể (bao gồm cả file và thư mục con)
        public static void Bai14()
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine($"Bài 14: Cấu trúc thư mục tại: {folderPath}");
            PrintDirectoryStructure(folderPath, "");
        }

        private static void PrintDirectoryStructure(string dir, string indent)
        {
            try
            {
                foreach (var file in Directory.GetFiles(dir))
                {
                    Console.WriteLine($"{indent}|-- File: {Path.GetFileName(file)}");
                }
                foreach (var subDir in Directory.GetDirectories(dir))
                {
                    Console.WriteLine($"{indent}+-- Dir: {Path.GetFileName(subDir)}");
                    PrintDirectoryStructure(subDir, indent + "    ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{indent} [Lỗi: {ex.Message}]");
            }
        }

        // 15. Thống kê ký tự/chữ số và lưu vị trí (dòng, cột) bằng Jagged Array
        public static void Bai15()
        {
            string path = "test_stats.txt";
            File.WriteAllLines(path, new string[] {
                "Hello CSharp 2026!",
                "Data Science UEH."
            });

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                Dictionary<char, List<(int row, int col)>> positions = new Dictionary<char, List<(int, int)>>();

                for (int i = 0; i < lines.Length; i++)
                {
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        char c = lines[i][j];
                        if (!positions.ContainsKey(c))
                        {
                            positions[c] = new List<(int, int)>();
                        }
                        positions[c].Add((i + 1, j + 1)); // (Dòng, Cột) tính từ 1
                    }
                }

                Console.WriteLine("Bài 15:  THỐNG KÊ KÝ TỰ VÀ VỊ TRÍ (JAGGED ARRAY)");
                foreach (var pair in positions)
                {
                    if (char.IsWhiteSpace(pair.Key)) continue;

                    int[][] jaggedPos = pair.Value.Select(p => new int[] { p.row, p.col }).ToArray();

                    Console.Write($"Ký tự '{pair.Key}' xuất hiện {jaggedPos.Length} lần tại vị trí: ");
                    foreach (var pos in jaggedPos)
                    {
                        Console.Write($"[D{pos[0]}, C{pos[1]}] ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}