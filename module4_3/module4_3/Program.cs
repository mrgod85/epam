using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter а");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter в");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c");
            double c = Convert.ToDouble(Console.ReadLine());
            tri(ref a, b, c);
            Console.WriteLine("increase the value of the elements by 10");
            Console.WriteLine("That is: " + a + " " + b + " " + c);
            krug(ref a, b);
            Console.WriteLine("Circumference: " + a + ", area of ​​a circle: " + b);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void tri(ref double a, double b, double c)
        {
            a = a + 10;
            b = b + 10;
            c = c + 10;
        }
        static void krug(ref double a, double b)
        {
            double pi = Math.PI;
            a = 2 * pi * a;
            b = pi * a * a;
            Console.WriteLine("Find circumference and area of ​​a circle");
        }
    }
}
