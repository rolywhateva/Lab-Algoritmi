using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatsuba
{
    class Program
    {
        static  long    Multiply(long a, long  b)
        {
            if (a < 10 || b < 10)
                return a * b;
            else
                return Multiply(a / 10, b / 10) * 100 + ((a / 10) * (b % 10) + (b / 10) * (a % 10)) * 10 + (a % 10) * (b % 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine((long)12346*236778);
            Console.WriteLine(Multiply(12346 , 236778));
        }
    }
}
