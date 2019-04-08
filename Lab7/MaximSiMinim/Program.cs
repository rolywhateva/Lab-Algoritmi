using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximSiMinim
{
    class Program
    {
        static  int  Maxim(int[] v, int st, int dr)
        {
            if (st == dr) return v[st];
            else
            {
                int m = (st + dr) / 2;
                int max1 = Maxim(v, st, m-1);
                int max2 = Maxim(v, m+1, dr);
                return Math.Max(max1, max2);
            }
        }
        static int Minim(int[] a, int st, int dr)
        {
            if (st == dr) return a[st];
            else
            {
                int m = (st + dr) / 2;
                int min1 = Minim(a, st, m - 1);
                int min2 = Minim(a, m + 1, dr);
                return Math.Min(min1, min2);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[] {10};
            Console.WriteLine(Maxim(a, 0, a.Length - 1));
            Console.WriteLine(Minim(a,0,a.Length-1));
        }
    }
}
