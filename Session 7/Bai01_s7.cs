using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_7
{
    public class Bai01_s7
    {
        public static void Run()
        {

            string str = "Phu Map";
            //in chuỗi
            Console.WriteLine($"Chuoi: {str}");

            
            //in độ dài chuỗi

            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            Console.WriteLine($"Do dai chuoi: {length}");

            
            //tách ký tự trong chuỗi
            Console.Write("Tach ky tu trong chuoi: ");
            foreach (char c in str)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();


            //in ngược chuỗi
            Console.Write("Chuoi nguoc: "); 
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write($"{str[i]}");
            }
            Console.WriteLine();

            // đếm số từ (lưu ý là TỪ khác với độ dài)
            int word = 0;
            bool inWord = false;
            for (int i = str.Length - 1; i>=0; i--)
            {
                char c = str[i];
                if ( c != ' ' && c!= '\n' && c != '\t')
                {
                    if (!inWord)
                    {
                        word++;
                        inWord = true;
                    }
                }
                else
                {
                     inWord = false; 
                }
            }
            Console.WriteLine($"So tu: {word}");

            //so sánh 2 chuỗi
            string str2 = "A big lIon";
            bool isEqual = true;
            int len2 = 0;
            foreach (char c in str2)
            {
                len2++;
            }
            if (length != len2)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (str[i] != str2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"2 chuoi co giong nhau khong? {isEqual}");

       

            //đếm chữ cái, chữ số, ký tự đặc biệt
            int alphabet = 0, digit = 0, specialChar = 0;
            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    alphabet++;
                }
                else if (c >= '0' && c <= '9')
                {
                    digit++;
                }
                else if (c != ' ' && c != '\t' && c != '\n')
                {
                    specialChar++;
                }
            }
            Console.WriteLine($"Chu cai: {alphabet} | Chu so: {digit} | Ky tu dac biet: {specialChar}");

            //đếm nguyên âm, phụ âm
            int vowels = 0, consonants = 0;
            foreach (char c in str)
            {
                char lower = (c >= 'A' && c <= 'Z') ? (char)(c + 32) : c;
                if (lower >= 'a' && lower <= 'z')
                {
                    if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }
            Console.WriteLine($"8. Nguyên âm: {vowels} | Phụ âm: {consonants}\n");

            // --- 9, 10, 12. Tìm chuỗi con (Kiểm tra tồn tại, Vị trí & Số lần xuất hiện) ---
            int subLen = 0;
            string sub = "Map";
            foreach (char c in sub) subLen++;

            int firstPos = -1;
            int countSub = 0;

            for (int i = 0; i <= length - subLen; i++)
            {
                bool match = true;
                for (int j = 0; j < subLen; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    if (firstPos == -1) firstPos = i;
                    countSub++;
                }
            }

            Console.WriteLine($"9. Chuỗi con '{sub}' có tồn tại không: {firstPos != -1}");
            Console.WriteLine($"10. Vị trí xuất hiện đầu tiên của '{sub}': {firstPos}");
            Console.WriteLine($"12. Số lần chuỗi con '{sub}' xuất hiện: {countSub}\n");

            //  11. Kiểm tra 1 ký tự có phải chữ cái không & HOA/thường 
            char ch = 'P';
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                string caseType = (ch >= 'A' && ch <= 'Z') ? "IN HOA" : "in thường";
                Console.WriteLine($"11. Ký tự '{ch}' là chữ cái ({caseType})\n");
            }
            else
            {
                Console.WriteLine($"11. Ký tự '{ch}' không phải là chữ cái\n");
            }

            //  Chèn chuỗi con vào trước lần xuất hiện đầu tiên 
            if (firstPos != -1)
            {
                string result = "";
                for (int i = 0; i < firstPos; i++) result += str[i];
                result += sub;
                for (int i = firstPos; i < length; i++) result += str[i];

                Console.WriteLine($"13. Chuỗi sau khi chèn '{sub}' vào trước: {result}\n");
            }

        }
    }
}
