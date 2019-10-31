using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        enum Operation
        {
            one = 2,
            two,
            three = one + two,
        }
        public int TotalNumberOfDaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}
