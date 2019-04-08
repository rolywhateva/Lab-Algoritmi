using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static bool BS(int[] v, int  st, int dr,int x)
        {
            int m = (st + dr) / 2;
            if (st < dr)
            {
                if (v[m] == x)
                    return true;
                else
                if (v[m] > x) return BS(v, st, m-1, x);
                else
                      if (v[m] < x) return BS(v, m+1, dr, x);
            }
            return false;

        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine(BS(a,0,a.Length-1,7));
            Console.WriteLine(BS(a, 0, a.Length - 1, 14));
            a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(BS(a,0,a.Length-1,4));
        }
    }
}
