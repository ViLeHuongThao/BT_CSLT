using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Cơ_sở_lập_trình
{

    internal class SS06
    {
        static void Main()
        {
            //EX01();
            EX02();
            Console.ReadKey();
        }
        static void EX01()
        {
            Console.Write("Enter a number: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter a number: ");
                bool res = int.TryParse(Console.ReadLine(), out array[i]);
                if (!res)
                {
                    Console.Write(" Please enter a number: ");
                    i--;
                }
            }
            foreach (int item in array) { Console.WriteLine(item); }
            Console.WriteLine("new array: ");
            //cộng mỗi phần tử thêm 2
            change(array);
            //foreach (int item in array) { Console.WriteLine(item); }
            for (int count = 0; count < array.Length; count++) { Console.WriteLine(array[count]); }//in mảng mới

            static void change(int[] array) //function
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] += 2;

            }
        }


        static void EX02()
        {
            //Tạo 1 mảng ngẫu nhiên
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            CreateARandomArray(array, length);
            void CreateARandomArray(int[] array, int length)
            {
                Random rnd = new Random();
                for (int i = 0; i < length; i++) { array[i] = rnd.Next(0, 100); }

                //linear search:
                static int LinearSearch(int[] array, int x)
                {
                    for (int index = 0; index < array.Length; index++)
                        if (array[index] == x)
                            return index;
                    return -1;
                }
            }
        }
    }
}

