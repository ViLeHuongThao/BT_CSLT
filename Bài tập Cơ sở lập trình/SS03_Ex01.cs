using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Cơ_sở_lập_trình
{
    internal class SS03_Ex01
    {
        public static void Main()
        {
            //Q1();
            //Q2();
            Q3();
            Console.ReadKey();
        }
        public static void Q1()
        {
            Console.Write("Nhap so do Celsius: ");
            double Celsius = double.Parse(Console.ReadLine());
            double Kelvin = Celsius + 273;
            double Fahrenheit = Celsius * 18 / 10 + 32;
            Console.WriteLine($"Kelvin = {Kelvin}");
            Console.WriteLine($"Fahrenheit = {Fahrenheit}");
            Console.ReadKey();
        }

        public static void Q2()
        {
            Console.Write("Enter radius: ");
            long r = long.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface: {surface}");
            Console.WriteLine($"Volume: {volume}");
        }
        public static void Q3()
        {
            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a/b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");

        }
    }
}
