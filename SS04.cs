using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Cơ_sở_lập_trình
{
   internal class SS04()
    {
        public static void Main()
        {
            //Ex_01();
            //Ex_02();
            //Ex_03();
            //Ex_1();
            //Ex_2();
            //Ex_3();
            //Ex_4_2();
            //Ex_4_3();
            Ex_6();
            //Ex_7();
            //Ex_8();
            Console.ReadKey();
        }
        public static void Ex_01()
        //kiểm tra số chẵn hay lẻ
        {
            Console.Write("Nhap so can kiem tra: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} la so chan");
            else
                Console.WriteLine($"{num} la so le");
        }
        public static void Ex_02()
        //tìm số lớn nhất trong 3 số
        {
            Console.WriteLine("Luu y: Khong nhap cac so bang nhau");
            Console.Write("Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c = ");
            int c = int.Parse(Console.ReadLine());
            if (a < b)
            {
                if (b < c)
                    Console.WriteLine($"{c} la so lon nhat");
                else
                    Console.WriteLine($"{b} la so lon nhat");
            }
            else
            {
                if (a > c)
                    Console.WriteLine($"{a} la so lon nhat");
            }
        }
        public static void Ex_03()
        //kiểm tra tọa độ (x,y) thuộc góc phần tư thứ mấy
        {
            Console.Write("Nhap toa do x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y = ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin.");
            }
            else if (x == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y axis.");
            }
            else if (y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X axis.");
            }
        }
        public static void Ex_1()
        //kiem tra tam giac
        {
            Console.Write("Nhap canh a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c = ");
            int c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b || b == c || c == a)
                {
                    if (a == b && b == c)
                        Console.WriteLine("Day la tam giac deu");
                    else
                        Console.WriteLine("Day la tam giac can");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong");
                }
            }
            else Console.WriteLine("Day khong phai la tam giac");
        }
        public static void Ex_2()
        //tinh trung binh cong va tong
        {
            int tong = 0;
            Console.WriteLine("Nhap lan luot 10 so");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"So thu {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                tong += tong;
            }
            double tb = tong / 10.0;

            Console.WriteLine($"Tong cua 10 so: {tong}");
            Console.WriteLine($"Trung binh cong cua 10 so: {tb}");
        }
        public static void Ex_3()
        //Hien thi bang cuu chuong cua 1 so 
        {
            Console.Write("Nhap 1 so de in bang cuu chuong: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong cua {so}: ");
            for (int i = 1; i <= 10; i++)
            {
                int kq = so * i;
                Console.WriteLine($"{so} x {i} = {kq}");
            }
        }
        public static void Ex_4_1()
        //Hàm in ra các pattern của số
        //Pattern 1
        {
            Console.Write("Nhap so ket thuc cua day: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) //lặp lại theo chiều dọc
            {
                for (int j = 1; j <= i; j++) //lặp theo chiều ngang
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void Ex_4_2()
        //Pattern 2
        {
            Console.Write("Nhap so bat dau: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong cua mau: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++) //lặp lại rows lần theo chiều dọc
            {
                for (int j = 1; j <= i; j++) //lặp theo chiều ngang
                {
                    Console.Write($"{n} ");
                    n++;
                }
                Console.WriteLine();
            }
        }
        public static void Ex_4_3()
        //Pattern 3
        {
            int n = 1;
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int s = 1; s <= rows - i; s++) //In khoảng trắng cho mỗi dòng
                                                    //số khoảng trắng ở dòng thứ i giảm 1
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{n} ");
                    n++;
                }
                Console.WriteLine();
            }
        }
        public static void Ex_6()
        //Nhập số n và trả về tổng của dãy 1 + 1/2 +......+ 1/n
        {
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.Write("Hay nhap 1 so nguyen duong: ");
                return;
            }
            double sum = 0;
            Console.Write($"Chuoi Harmonic voi n = {n}: ");
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write($"1/{i}");
                if (i < n)
                    Console.Write(" + ");
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua chuoi Harmonic: {sum}");
        }
        public static void Ex_7()
        //Tìm ra số hoàn hảo trong một khoảng cho trước
        {
            Console.Write("Nhap so bat dau cua khoang: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ket thuc cua khoang: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cac so hoan hao trong khoang tu {a} den {b}: ");
            for (int n = a; n <= b; n++)
            {
                if (IsPerfect(n))
                    Console.WriteLine(n);
            }
        }
        static bool IsPerfect(int number) //Hàm IsPerfect 
        {
            int sum = 0;
            // Tính tổng các ước số (trừ chính nó)
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) // Nếu i là ước của number
                {
                    sum += i; // Cộng i vào tổng
                }
            }
            // Kiểm tra nếu tổng các ước bằng chính số đó
            return sum == number;
        }
        public static void Ex_8()
        //kiểm tra xem 1 số có phải là số nguyên tố hay không
        {
            Console.Write("Nhap so can kiem tra: ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine($"{num} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{num} khong phai la so nguyen to.");
            }
        }
        // Hàm kiểm tra số nguyên tố
        static bool IsPrime(int y)
        {
            if (y < 2) return false;
            if (y == 2) return true;
            for (int i = 2; i <= (y - 1); i++)
                if (y % i == 0)
                    return false;
            return true;
        }

    }
}
