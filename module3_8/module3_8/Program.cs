using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_8
{
    class Program
    {
        private const double EPSILON = .001;

        private static void Main()
        {

            Console.Write(" n = ");
            int N = int.Parse(Console.ReadLine());//границы снизу и сверху
            int[,] MM = new int[N, N];
            int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = N;

            for (int i = 0; i < MM.Length; i++)
            {
                MM[row, col] = i + 1;

                if (--gran == 0)
                {
                    gran = N * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dy;
                    dy = -dx;
                    dx = temp;
                    dirChanges++;
                }

                col += dy;
                row += dx;
            }

            for (int i = 0; i < MM.GetLength(0); i++)
            {
                for (int j = 0; j < MM.GetLength(0); j++)
                {
                    Console.Write(MM[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            Console.Write("Начало отрезка по x = ");
            double begin = double.Parse(Console.ReadLine());

            Console.Write("Конец отрезка по x = ");
            double end = double.Parse(Console.ReadLine());

            if (CheckExtreme(F(begin)) || CheckExtreme(F(end)))
                return;

            double dz = end - begin;
            double avg = (begin + end) / 2;
            while (Math.Abs(F(avg)) > EPSILON)
            {
                dz /= 2;
                avg = begin + dz;
                if (Math.Sign(F(begin)) == Math.Sign(F(avg)))
                    begin = avg;
            }

            Console.WriteLine(avg);
        }

        private static bool CheckExtreme(double value)
        {
            if (Math.Abs(F(value) - 0) < EPSILON)
            {
                Console.WriteLine(value);
                return true;
            }
            return false;
        }
        private static double F(double x)
        {
            return 2 * x - 10;
        }
        
    }
}
