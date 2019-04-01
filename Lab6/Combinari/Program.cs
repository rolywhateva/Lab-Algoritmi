using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinari
{
    class Program
    {
        static void bk(int k, int p, int n, int[] sol, bool[] b)
        {
            if (k > p)
            {
                for (int i = 1; i <= p; i++)
                    Console.Write(sol[i] + "\t");
                Console.WriteLine();
            }
            else
            {
                for (int i = sol[k - 1] + 1; i < n; i++)
                {
                    sol[k] = i;
                    //b[i] = true;
                    bk(k + 1, p, n, sol, b);
                   // b[i] = false;
                }
                    
            }
        }
            static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int p;
            Console.Write("p=");
            p = int.Parse(Console.ReadLine());

            int[] sol = new int[n+1];
            bool[] b = new bool[n];
            bk(1, p, n, sol, b);

        }
    }
}
