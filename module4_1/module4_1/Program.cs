using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_1
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
            Console.Write("The maximum element in the array: ");
            MAX(a);
            Console.Write("The minimum element in the array: ");
            MIN(a);
            Console.Write("Summ of elements in an array: ");
            SUMM(a);
            Console.Write("The difference between the max and min elements in the array: ");
            RAZN(a);
            Console.WriteLine("Task D: ");
            massive(a);
            Console.ReadKey();
        }
        static void MAX(int[] a)
        {
            int maxValue = a.Max();
            Console.WriteLine(maxValue);
        }
        static void MIN(int[] a)
        {
            int minValue = a.Min();
            Console.WriteLine(minValue);
        }
        static void SUMM(int[] a)
        {
            int rez = a.Sum();
            Console.WriteLine(rez);
        }
        static void RAZN(int[] a)
        {
            int raz = a.Max() - a.Min();
            Console.WriteLine(raz);
        }
        static void massive(int[] a)
        {
            int max = a.Max();
            int min = a.Min();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0) a[i] = a[i] / min;
                else a[i] = a[i] = max * max;            
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}
