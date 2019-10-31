using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш возраст:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0 & n > 18)
            {
                Console.WriteLine("Поздравляем с 18-летием!");
            }
            else if (n % 2 != 0 & n < 18 & n > 13)
            {
                Console.WriteLine("Поздравляем, школьник!");
            }
            else Console.WriteLine("чо за нах");
            Console.ReadKey();
        }
    }
}
