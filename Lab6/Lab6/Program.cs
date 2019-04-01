using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void bk(int k, int n, int[] sol)
        {
            if(k>=n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(sol[i] + "\t");
                Console.WriteLine();
            }else
            {
                for(int i=0;i<n;i++)
                {
                    sol[k] = i + 1;
                    bk(k + 1, n, sol);

                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int[] sol = new int[n];
            bk(0, n, sol);
        }
    }
}
