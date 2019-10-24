using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i ++)
            {
                Console.Write(a + ", ");
                b = b + a;
                a = b - a;
            }
            Console.Write(" Расчет окончен");
            Console.ReadKey();
        }
    }
}
