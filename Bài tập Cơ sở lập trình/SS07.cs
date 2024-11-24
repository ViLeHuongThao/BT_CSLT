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
            static int TimMin(int[,] a, ref int min)
            {

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min) { min = a[i, j]; }
                    }
                }
                return min;
            }
            static void EX01()
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
                TimMin(a, ref min);
                Console.WriteLine("So nho nhat trong mang la: " + min);
            }
        }
    }




