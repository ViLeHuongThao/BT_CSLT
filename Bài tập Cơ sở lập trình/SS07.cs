using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Cơ_sở_lập_trình
{

    internal class SS07
    {
        static void Main()
            {
                EX01();
            Console.ReadKey();
            }

            static void TaoMang(int[,] a, int rows, int columns)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Random rnd = new Random();
                        a[i, j] = rnd.Next(0, 100);
                    }
                }
            }
            static void XuatMang(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(a[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
            }
            static void InCot(int[,] a, int y)
            {
                if (y >= a.GetLength(1) || y < 0)
                {
                    Console.WriteLine($"Khong co cot thu {y}");
                    return;
                }
                Console.WriteLine($"Cot thu {y}: ");
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    Console.WriteLine(a[i, y]);
                }

            }
            static void InDong(int[,] a, int y)
            {
                if (y >= a.GetLength(0) || y < 0)
                {
                    Console.WriteLine($"Khong co dong thu {y}");
                    return;
                }
                Console.Write($"Dong thu {y}: ");
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    Console.Write(a[y, i] + "\t");
                }
            }

            static int TimMax(int[,] a, ref int max)
            {

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max) { max = a[i, j]; }
                    }
                }
                return max;
            }
             static void TimMinDong(int[,] a)
            {
               int min = a[0, 0];
               Console.Write("Nhap dong can tim Min: ");
               int dong = int.Parse(Console.ReadLine());
               for (int i = 0; i < a.GetLength(0); i++)
            {
            for (int j = 0; j < a.GetLength(1); j++)
            {
             if (dong - 1 == i)
             {
                 if (min > a[i, j])
                     min = a[i, j];
             }
            }
            }
             Console.WriteLine($"Gia tri nho nhat cua dong {dong} la: {min}");
           }
                static void TimMinCot(int[,] a)
        {
            int min = a[0, 0];
            Console.Write("Nhap cot can tim Min: ");
            int cot = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (cot - 1 == j)
                    {
                        if (min > a[i, j])
                            min = a[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri nho nhat cua cot {cot} la: {min}");
        }
        static int[,] ChuyenVi(int[,] a)
        {
            int rows = a.GetLength(0); // số hàng của ma trận a
            int cols = a.GetLength(1); // số cột của ma trận a
            int[,] MaTranChuyenVi = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                { MaTranChuyenVi[j, i] = a[i, j]; }
            }
            return MaTranChuyenVi;
        }
        static void InMaTranChuyenVi(int[,] MaTranChuyenVi)
        {
            for (int i = 0; i < MaTranChuyenVi.GetLength(1); i++)
            {
                for (int j = 0; j < MaTranChuyenVi.GetLength(0); j++)
                {
                    Console.Write(MaTranChuyenVi[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void DuongCheoChinh(int[,] a)
        {
            int x = a.GetLength(0);
            int y = a.GetLength(1);
            if (x != y)
            {
                Console.WriteLine("Ma tran khong vuong nen khong co duong cheo chinh");
                return;
            }
            for (int i = 0;i<x; i++)
            {
                Console.Write(a[i, i] + " ");
            }    
        }
        static void DuongCheoPhu(int[,] a)
        {
            int n = a.GetLength(0); // Số hàng
            int m = a.GetLength(1); // Số cột
            if (n != m)
            {
                Console.WriteLine("Matrix is not square, no secondary diagonal.");
                return;
            }
            for (int i = 0; i < n; i++) 
            {
                Console.Write(a[i, n - i - 1] + "\t");
                //dòng 0 thì cột n-1, dòng n-1 thì cột 0
            }
        }
            static void Main()
            {
                int[,] a;
                Console.Write("Nhap so dong: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Nhap so cot: ");
                int cols = int.Parse(Console.ReadLine());
                a = new int[rows, cols];
                TaoMang(a, rows, cols);
                XuatMang(a);
                Console.WriteLine();

                Console.Write("Ban muon in dong hay cot: "); string n; n = Console.ReadLine().ToLower();
                Console.Write("Ban muon in dong/cot thu may: "); int y = int.Parse(Console.ReadLine());
                if (n == "cot") { InCot(a, y); };
                if (n == "dong") { InDong(a, y); };

                int max = int.MinValue;
                TimMax(a, ref max);
                Console.WriteLine("So lon nhat trong mang la: " + max);

                int min = int.MaxValue;
                TimMinDong(a);
                TimMinCot(a);

                ChuyenVi(a);
                InMaTranChuyenVi(a);

                DuongCheoChinh(a);
                DuongCheoPhu(a);
            }
        }
    }




