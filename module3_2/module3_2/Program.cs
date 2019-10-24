using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите натуральное число N: ");
            int N = int.Parse(Console.ReadLine());
            int i = 1, k = 1;
            while (true)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    k++;
                }
                if (k > N)
                {
                    break;
                }
                i++;
            }
            Console.ReadKey();
            
        }
    }
}
