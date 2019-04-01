using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutari
{
    class Program
    {
        static void bk(int k, int n, int[] sol,bool[] b)
        {
            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(sol[i] + "\t");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                    if(!b[i])
                {
                    sol[k] = i + 1;
                        b[i] = true;
                    bk(k + 1, n, sol,b);
                        b[i] = false;

                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int[] sol = new int[n];
            bool[] b = new bool[n];
            bk(0, n, sol,b);
        }
    }
}
