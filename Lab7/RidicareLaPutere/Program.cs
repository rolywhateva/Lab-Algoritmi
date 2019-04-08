using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RidicareLaPutere
{
    class Program
    {
        static int Putere(int a, int b)
        {
            if (b == 0) return 1;
            if (b == 1) return a;
            else
                if (b % 2 == 0)
                return a*Putere(a, b / 2);
            else
                return a * Putere(a, b - 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Putere(3,2));
        }
    }
}
