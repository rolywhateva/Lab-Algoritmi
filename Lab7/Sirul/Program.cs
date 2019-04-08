using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirul
{
    class Program
    {
        static void T(int n)
        {
            if (n == 1)
                Console.Write(1);
            else
            {
                T(n - 1);
                Console.Write(n);
                T(n - 1);

            }
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                T(i);
                Console.WriteLine();
            }
        }
    }
}
