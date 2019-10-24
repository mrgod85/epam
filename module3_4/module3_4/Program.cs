using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            string str = Console.ReadLine();
            int revCh = 0;
            try
            {
                System.Diagnostics.Debug.Assert(str != null, "str != null");
                int ch = int.Parse(str);
                while (ch != 0)
                {
                    revCh = revCh * 10 + ch % 10;
                    ch /= 10;
                }
                Console.WriteLine(revCh);
            }
            catch (Exception)
            {
                Console.WriteLine("Надо было ввести целое число!");
            }
            Console.ReadKey();
        }
    }
}
