using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество элементов массива");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < a[i + 1])
                {
                Console.WriteLine("число массива,больше предыдущего= {1}", i + 1, a[i + 1]);
                }
            }
            Console.ReadKey();
        }
    }
}
