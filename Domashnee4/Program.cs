using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashnee4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1, x2 = 1, x3 = 1; i <= x1; i++, x3 += 2, x2 = x2 + x3)
            {
                Console.WriteLine("квадрат числа {0} равен {1}", i, x2);
            }
            Console.ReadKey();
        }
    }
}
