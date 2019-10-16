using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число компаний, работающих в стране:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите налог в процентах:");
            int m = Convert.ToInt32(Console.ReadLine());
            int a = 500;
            int b = a * n * m / 100;
            Console.Write("сумма налога = {0}", b);
            Console.ReadKey();
        }
    }
}
