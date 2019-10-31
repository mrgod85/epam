using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray;
            Console.Write("Enter the dimension of the array: ");
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n];
            for (int i = 0; i < MyArray.Length; ++i)
            {
                Console.Write("a[{0}]=", i);
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sort by UP (1) or DOWN (2) ");
            string v = Console.ReadLine();
            switch (v)
            {
                case "1":
                    Array.Sort(MyArray);
                    Array.ForEach(MyArray, Console.WriteLine);
                    break;
                case "2":
                    Array.Sort(MyArray, (x, y) => -x.CompareTo(y));
                    Array.ForEach(MyArray, Console.WriteLine);
                    break;
            }
            Console.ReadKey();
        }
    }
}
