using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regina
{
    class Program
    {
        static void bk(int k, int n, int[] sol, bool[] b)
        {
            if (k >= n)
            {
                if (solutie(sol))
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                            if (sol[i] == j)
                                Console.Write("D");
                            else
                                Console.Write("x");
                        Console.WriteLine();

                    }
                    Console.WriteLine("==========");
                    Console.ReadKey();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                    if (!b[i])
                    {
                        sol[k] = i + 1;
                        b[i] = true;
                        bk(k + 1, n, sol, b);
                        b[i] = false;

                    }
            }
        }

        private static bool solutie(int[] sol)
        {
            for (int i = 0; i < sol.Length; i++)
                for (int j = i + 1; j < sol.Length; j++)
                    if (Math.Abs(i - j) == Math.Abs(sol[i] - sol[j]))
                        return false;
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int[] sol = new int[n];
            bool[] b = new bool[n];
            bk(0, n, sol, b);
        }
    }
}
