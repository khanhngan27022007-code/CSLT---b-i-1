using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session6
{
    internal class Bai01_s6
    {
        public static void Run()
        {
            Console.WriteLine("PART 1: ARRAY OPERATIONS");
            int[] arr = CreateRandomArray(10, 1, 50);
            PrintArray("Mang ngau nhien ban dau:", arr);

            // 1. Average value
            Console.WriteLine($"1. Gia tri trung binh: {CalculateAverage(arr):F2}");

            // 2. Contains specific value
            int target = arr[2]; // Lay mot phan tu trong mang de test
            Console.WriteLine($"2. Mang co chua {target} khong: {ContainsValue(arr, target)}");

            // 3. Find index
            Console.WriteLine($"3. Vi tri (index) dau tien cua {target}: {FindIndex(arr, target)}");

            // 4. Remove a specific element (xoa tat ca phan tu co gia tri bang target)
            int[] removedArr = RemoveElement(arr, target);
            PrintArray($"4. Mang sau khi xoa phan tu {target}:", removedArr);

            // 5. Max and Min
            FindMaxMin(arr, out int maxVal, out int minVal);
            Console.WriteLine($"5. Max = {maxVal}, Min = {minVal}");

            // 6. Reverse array
            int[] reversedArr = ReverseArray(arr);
            PrintArray("6. Mang sau khi dao nguoc:", reversedArr);

            // 7. Find duplicate values
            Console.Write("7. Cac gia tri bi trung lap: ");
            FindDuplicates(arr);

            // 8. Remove duplicate elements
            int[] uniqueArr = RemoveDuplicates(arr);
            PrintArray("8. Mang sau khi xoa cac phan tu trung lap:", uniqueArr);


            Console.WriteLine("\nPART 2: SORTING & SEARCHING");
            // Request 10 integers & Bubble Sort
            int[] userArr = InputArray(10);
            BubbleSort(userArr);
            PrintArray("Mang 10 so sau khi sap xep (Bubble Sort):", userArr);

            // Linear search word in sentence
            Console.Write("\nNhap vao mot cau: ");
            string sentence = Console.ReadLine();
            Console.Write("Nhap tu can tim: ");
            string word = Console.ReadLine();
            bool found = LinearSearchWord(sentence, word);
            Console.WriteLine($"Ket qua tim kiem tu '{word}': {(found ? "Co xuat hien" : "Khong xuat hien")}");


            Console.WriteLine("\nPART 3: MATRIX OPERATIONS");
            Console.Write("Nhap so dong N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = CreateRandomMatrix(n, m, 1, 99);
            Console.WriteLine("\nMa tran duoc tao ngau nhien:");
            PrintMatrix(matrix);

            // Print ith row and column
            Console.Write($"\nNhap chi so i (0 den {n - 1} cho dong, 0 den {m - 1} cho cot): ");
            int index = int.Parse(Console.ReadLine());
            PrintRow(matrix, index);
            PrintColumn(matrix, index);

            // Max value of matrix
            Console.WriteLine($"\nGia tri lon nhat trong ma tran: {FindMatrixMax(matrix)}");

            // Min value of ith row/column
            Console.WriteLine($"Gia tri nho nhat cua dong {index}: {FindRowMin(matrix, index)}");
            Console.WriteLine($"Gia tri nho nhat cua cot {index}: {FindColMin(matrix, index)}");

            // Transpose matrix
            int[,] transposed = TransposeMatrix(matrix);
            Console.WriteLine("\nMa tran chuyen vi (Transpose):");
            PrintMatrix(transposed);

            // Main and Secondary diagonal (Neu la ma tran vuong)
            if (n == m)
            {
                PrintDiagonals(matrix);
            }
            else
            {
                Console.WriteLine("\nKhong in duoc duong cheo vi day khong phai ma tran vuong (N != M).");
            }
        }

        #region --- PART 1 HELPER FUNCTIONS ---

        public static int[] CreateRandomArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(min, max + 1);
            return arr;
        }

        public static double CalculateAverage(int[] arr)
        {
            double sum = 0;
            foreach (int val in arr) sum += val;
            return sum / arr.Length;
        }

        public static bool ContainsValue(int[] arr, int target)
        {
            foreach (int val in arr)
                if (val == target) return true;
            return false;
        }

        public static int FindIndex(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == target) return i;
            return -1;
        }

        public static int[] RemoveElement(int[] arr, int target)
        {
            int count = 0;
            foreach (int val in arr)
                if (val != target) count++;

            int[] result = new int[count];
            int idx = 0;
            foreach (int val in arr)
            {
                if (val != target)
                {
                    result[idx] = val;
                    idx++;
                }
            }
            return result;
        }

        public static void FindMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }

        public static void FindDuplicates(int[] arr)
        {
            bool foundAny = false;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate) continue;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write($"{arr[i]} ");
                        foundAny = true;
                        break;
                    }
                }
            }
            if (!foundAny) Console.Write("Khong co phan tu trung");
            Console.WriteLine();
        }

        public static int[] RemoveDuplicates(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int uniqueCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!ContainsValue(temp, arr[i]) || (arr[i] == 0 && uniqueCount == 0))
                {
                    temp[uniqueCount] = arr[i];
                    uniqueCount++;
                }
            }

            int[] result = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        #endregion

        #region --- PART 2 HELPER FUNCTIONS ---

        public static int[] InputArray(int size)
        {
            int[] arr = new int[size];
            Console.WriteLine($"\nNhap vao {size} so nguyen:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Phan tu [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static bool LinearSearchWord(string sentence, string word)
        {
            string[] words = sentence.Split(new char[] { ' ', '\t', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        #endregion

        #region --- PART 3 HELPER FUNCTIONS ---

        public static int[,] CreateRandomMatrix(int rows, int cols, int min, int max)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rand.Next(min, max + 1);
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        public static void PrintRow(int[,] matrix, int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= matrix.GetLength(0)) return;
            Console.Write($"Dong {rowIndex}: ");
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[rowIndex, j]} ");
            Console.WriteLine();
        }

        public static void PrintColumn(int[,] matrix, int colIndex)
        {
            if (colIndex < 0 || colIndex >= matrix.GetLength(1)) return;
            Console.Write($"Cot {colIndex}: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                Console.Write($"{matrix[i, colIndex]} ");
            Console.WriteLine();
        }

        public static int FindMatrixMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int val in matrix)
                if (val > max) max = val;
            return max;
        }

        public static int FindRowMin(int[,] matrix, int rowIndex)
        {
            int min = matrix[rowIndex, 0];
            for (int j = 1; j < matrix.GetLength(1); j++)
                if (matrix[rowIndex, j] < min) min = matrix[rowIndex, j];
            return min;
        }

        public static int FindColMin(int[,] matrix, int colIndex)
        {
            int min = matrix[0, colIndex];
            for (int i = 1; i < matrix.GetLength(0); i++)
                if (matrix[i, colIndex] < min) min = matrix[i, colIndex];
            return min;
        }

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[j, i] = matrix[i, j];

            return result;
        }

        public static void PrintDiagonals(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            Console.Write("\nDuong cheo chinh (Main diagonal): ");
            for (int i = 0; i < n; i++)
                Console.Write($"{matrix[i, i]} ");

            Console.Write("\nDuong cheo phu (Secondary diagonal): ");
            for (int i = 0; i < n; i++)
                Console.Write($"{matrix[i, n - 1 - i]} ");
            Console.WriteLine();
        }

        #endregion

        #region --- UTILS ---
        public static void PrintArray(string label, int[] arr)
        {
            Console.WriteLine(label);
            foreach (int val in arr) Console.Write($"{val} ");
            Console.WriteLine("\n");
        }
        #endregion
    }
}