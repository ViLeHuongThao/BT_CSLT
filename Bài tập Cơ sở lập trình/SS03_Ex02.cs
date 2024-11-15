using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_Cơ_sở_lập_trình
{
    internal class SS03_Ex02
    {

        public static void Main()
        {
            //ss03_02();
            //ss03_03();
            ss03_05();
            Console.ReadKey();
        }
        public static void ss03_02()
        {

            int y = -5;
            double x;

            while (y <= 5)
            {
                x = Math.Pow(y, 2) + 2 * y + 1;
                Console.WriteLine($" y = {y}, x = {x}");
                y++;
            }
        }
        public static void ss03_03()
        {
            Console.Write("Enter the time (hours): ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter the time (minutes): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter the time (seconds): ");
            int s = int.Parse(Console.ReadLine());
            double h1 = h + m / 60.0 + s / 3600.0;
            Console.Write("Enter distance (kilometers): ");
            double k = Console.Read(); double mile = k * 0.621371;
            double v1 = k / h1; double v2 = mile / h1;
            Console.WriteLine($"Speed in kilometers per hour: {v1} km/h");
            Console.WriteLine($"Speed in miles per hour: {v2} miles/h");
        }
        public static void ss03_05()
        {
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine($"{input} is a vowel.");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine($"{input} is a digit.");
            }
            else
            {
                Console.WriteLine($"{input} is another symbol.");
            }
        }
    }
}

       
       

