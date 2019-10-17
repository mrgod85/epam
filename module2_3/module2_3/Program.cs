using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double result1;
            Console.WriteLine("введите первое число: a ");
            string a = Console.ReadLine().Replace('.', ',').Replace(' ', 'k');
            while (!Double.TryParse(a, out result1))
            {
                Console.WriteLine("Вводите именно число: a ");
                a = Console.ReadLine().Replace('.', ',').Replace(' ', 'k');
                continue;
            }

            Double result2;
            Console.WriteLine("введите второе число: b");
            string b = Console.ReadLine().Replace('.', ',').Replace(' ', 'k');
            while (!Double.TryParse(b, out result2))
            {
                Console.WriteLine("Вводите именно число: b");
                b = Console.ReadLine().Replace('.', ',').Replace(' ', 'k');
                continue;
            }
            double x = result1;
            result1 = result2;
            result2 = x;
            {
                Console.WriteLine("Результат : x={0} и y={1}", result1, result2);
            }
            Console.Read();
        }
    }
}
