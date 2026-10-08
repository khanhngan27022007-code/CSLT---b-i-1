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
            int vowel = 0, consonant = 0;

        }
    }
}
