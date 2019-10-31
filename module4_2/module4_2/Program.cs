using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                summ2(args);
                summ3(args);
                summ4(args);
                Con(args);
                massive(args);
                Console.WriteLine("Enter to exit");
                keyInfo = Console.ReadKey(true);
            }
            while (keyInfo.Key != ConsoleKey.Enter);
        }
        static void summ2(string[] args)
        {
            Console.WriteLine("Find the sum of two numbers. Enter а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter в");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("The sum of the two numbers entered is " + c);
            Console.WriteLine();
        }
        static void summ3(string[] args)
        {
            Console.WriteLine("Find the sum of three numbers. Enter а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter в");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = a + b + c;
            Console.WriteLine("The sum of the three numbers entered is " + d);
            Console.WriteLine();
        }
        static void summ4(string[] args)
        {
            Console.WriteLine("Find the sum of three fractional numbers:");
            Double result1;
            Console.WriteLine("Enter a ");
            double a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Enter в");
            double b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Enter c");
            double c = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            double d = a + b + c;
            Console.WriteLine("The sum of the three numbers entered is " + d);
            Console.WriteLine();
        }
        static void Con(string[] args)
        {
            Console.WriteLine("merge strings.");
            Console.WriteLine("enter first string: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter seconf sring: ");
            string s2 = Console.ReadLine();
            string s3 = s1 + " " + s2;
            string s4 = String.Concat(s3);
            Console.WriteLine("Result: " + s4);
        }
        static void massive(string[] args)
        {
            Random R = new Random();
            int s = R.Next(1, 10);
            int n = R.Next(1, 10);
            int m = s <= n ? n : s;
            int[] a1 = new int[s];
            int[] a2 = new int[n];
            int[] a3 = new int[m];
            Console.WriteLine("First random array");
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = R.Next(0, 100);
                Console.Write(a1[i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("Second random array");
            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = R.Next(0, 100);
                Console.Write(a2[i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("Summ of arrays");
            for (int i = 0; i < ((a1.Length < a2.Length) ? a1.Length : a2.Length); i++)
            {
                a3[i] = a1[i] + a2[i];
            }
            for (int i = ((a1.Length < a2.Length) ? a1.Length : a2.Length); i < a3.Length; i++)
            {
                a3[i] = ((a1.Length < a2.Length) ? a2[i] : a1[i]);
            }
            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write(a3[i] + "   ");
            }
                Console.WriteLine();
        }
    }
}
