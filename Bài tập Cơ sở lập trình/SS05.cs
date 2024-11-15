using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Cơ_sở_lập_trình
{

    internal class SS05
    {
        public static void Main() {
            //EX01();
            //EX02();
            //EX03();
            EX04();
            Console.ReadKey();
        }
        /// bài 1: Write a C# function to find the maximum of three numbers.
        public static void EX01()
        {
            static int maximum(int x, int y, int z)
            {
                int max = 0;
                if (x > y && x > z) { max = x; return max; }
                else if (y > x && y > z) { max = y; return max; }
                else { max = z; return max; }
            }
            static void Main(string[] args)
            {
                Console.Write("Enter number x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter number y: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Enter number z: ");
                int z = int.Parse(Console.ReadLine());
                int max = maximum(x, y, z);
                Console.WriteLine("The maximum of three numbers is " + max);
            }
        }
        /// <summary>
        /// bài 2. Write a C# function to calculate the factorial of a number (a non-negative integer). 
        /// </summary> The function accepts the number as an argument.
        /// <param name="a"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static void EX02()
        {
            static long CaculateTheFactorial(int a)
            {
                if (a < 0)
                    throw new Exception("Number must be non-negative.");
                if (a == 0 || a == 1)
                    return 1;
                else
                {
                    long Factorial = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        Factorial *= i;
                    }
                    return Factorial;
                }
            }
            static void Main()
            {
                Console.Write("Enter a non-negative integer: ");
                int a = int.Parse(Console.ReadLine());
                long Result = CaculateTheFactorial(a);
                Console.WriteLine($"Factorial of {a} is {Result}");
            }
        }
        public static void EX03()
        {
            /// <summary>
            /// b3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
            /// </summary>
            /// <param name="b"></param>
            /// <returns></returns>
            static bool IsPrime(int b)
            {
                if (b < 2) return false;
                if (b == 2) return true;
                for (int i = 2; i <= (b - 1); i++)
                    if (b % i == 0) return false;
                return true;
            }
            static void Main(string[] args)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                if (IsPrime(num))
                { Console.WriteLine($"{num} is a prime."); }
                else { Console.WriteLine($"{num} is not a prime."); }
            }
        }
        /// <summary>
        /// Write a C# function to print
        ///1. all prime numbers that less than a number(enter prompt keyboard).
        ///2. the first N prime numbers
        /// </summary>
        public static void EX04()
        {
            static bool IsPrime(int c)
            {
                if (c < 2) return false;
                if (c == 2) return true;
                for (int i = 2; i <= (c - 1); i++)
                    if (c % i == 0)
                        return false;
                return true;
            }
            static void Print_Prime_Less_Than(int n) {
                Console.WriteLine($"All prime numbers that less than {n}");
                for (int i = 2; i <= n; i++) {
                    if (IsPrime((int)i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            static void Print_First_N_Primes(int N)
            {
                Console.WriteLine($"The first {N} prime number: ");
                int number = 2;
                int Count = 0;
                while (Count < N)
                {
                    if (IsPrime(number))
                    {
                        Console.WriteLine(number);
                        Count++;
                    }
                    number++;
                }
                Console.WriteLine();
            }
            static void Main(){
                // Nhập giới hạn để tìm các số nguyên tố nhỏ hơn giới hạn
                Console.Write("Enter a number to print all prime numbers which is less than that number: ");
                int n = int.Parse(Console.ReadLine());
                Print_Prime_Less_Than(n);

                // Nhập số lượng số nguyên tố đầu tiên cần in ra
                Console.Write("Enter N to print the first N prime numbers: ");
                int limit = int.Parse(Console.ReadLine());
                Print_First_N_Primes(limit);
            }
        }
        public static void EX05() 
        {
        static bool IsPerfectNumber(int number)
    {
        int sum = 0;
        // Tính tổng các ước số (trừ chính nó)
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0) // Nếu i là ước của number
            {
                sum += i; // Cộng i vào tổng
            }
        }
        // Kiểm tra nếu tổng các ước bằng chính số đó
        return sum == number;
    }

    // Hàm chính
    static void Main(string[] args)
    {
        Console.WriteLine("Here are all perfect numbers that less than 1000: ";
        for (int i = 1; i < 1000; i++)
        {
            if (IsPerfectNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }
        }
        public static void EX06() 
        {
        }
    } 
    }

