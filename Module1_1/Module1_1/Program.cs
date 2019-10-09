using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.ReadKey();
        }
    }
}
