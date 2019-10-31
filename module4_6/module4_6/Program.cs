using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of elements in the array");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("add 5 to the elements: ");
            massive(a);
            Console.ReadKey();
        }
        static void massive(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] + 5;
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}
