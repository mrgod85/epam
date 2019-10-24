using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифру, которую нужно убрать:");
            long d = long.Parse(Console.ReadLine());
            long res = 0;
            long pow = 1;

            while (n != 0)
            {
                var temp = n % 10;
                n /= 10;
                if (temp == d) continue;
                res += temp * pow;
                pow *= 10;
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
