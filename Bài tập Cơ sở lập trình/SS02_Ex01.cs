using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Cơ_sở_lập_trình
{
    internal class SS02_Ex01
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            // Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();
            Console.ReadKey();
        }

        public static void Question_01()
        //To add/sum two numbers
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.Write($"{a}+{b}={c}");
        }
        public static void Question_02()
        //To swap values of two variables
        {
            Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {c}");
        }
        public static void Question_03()
        //To multiply 2 floating point numbers
        {
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("a x b =" + a * b);
        }
        public static void Question_04()
        //To convert feet to meter
        {
            Console.Write("Nhap so feets: ");
            double feet = double.Parse(Console.ReadLine());
            double meter;
            meter = feet / 3.2808399;
            Console.Write($" {feet} feets = {meter} meters");
        }
        public static void Question_05()
        ////To convert celsius to fahrenheit and vice versa
        {
            Console.Write("Nhap Celsius: ");
            double Celsius = double.Parse(Console.ReadLine());
            double Fahrenheit;
            Fahrenheit = Celsius * 33.8;
            Console.Write($" {Celsius} degree Celsius = {Fahrenheit} degree Fahrenheit"); Console.ReadKey();
            Console.WriteLine();
            Console.Write("Nhap Fahrenheit: ");
            double Fahrenheit1 = double.Parse(Console.ReadLine());
            double Celsius1;
            Celsius1 = Fahrenheit1 / 33.8;
            Console.Write($"{Fahrenheit1} degree Fahrenheit = {Celsius1} degree Celsius"); Console.ReadKey();
        }
        public static void Question_06()
        //To find the size of data types
        {
            Console.WriteLine($"{sizeof(int)}");
        }
        public static void Question_07()
        //To print ASCII value
        {
            Console.Write("Nhap 1 ky tu: ");
            char c = char.Parse(Console.ReadLine());
            int num = c;
            Console.Write($"{c} in ASCII = {num}");
        }
        public static void Question_08()
        //To calculate area of circle
        {
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(r, 2);
            Console.Write($"Dien tich hinh tron la: {s}");
        }
        public static void Question_09()
        //To calculate area of square
        {
            Console.Write("Nhap do dai canh cua hinh vuong: ");
            float a = float.Parse(Console.ReadLine());
            double S = Math.Pow(a, 2);
            Console.Write($"Dien tich hinh vuong la: {S}");
        }
        public static void Question_10()
        //To convert days to years, weeks and days
        {
            Console.Write("Nhap so ngay: ");
            uint n = uint.Parse(Console.ReadLine());
            uint nam = n / 365;
            uint tuan = (n - nam * 365) / 7; // có thể tính bằng phép chia lấy số dư: tuan = (n%365)/7
            uint ngay = n - nam * 365 - tuan * 7; //có thể tính bằng phép chia lấy số dư: (n%365)%7
            Console.Write($"{n} ngay bao gom {nam} nam, {tuan} tuan, {ngay} ngay");
        }
    }



}

