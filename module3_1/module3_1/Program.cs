using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= b; i++)
            {
                result += a;
            }
            Console.WriteLine("Произведение чисел a и b = к" + result);
            Console.ReadKey();
        }
    }
}
