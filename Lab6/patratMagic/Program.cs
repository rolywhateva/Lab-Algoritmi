using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patratMagic
{
    class Program
    {
        static void bk(int k, int n, int[] sol, bool[] b)
        {

            if (k >= n)
            {
                if (esteSolutie(sol))
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(sol[i] + "\t");
                        if ((i + 1) % 3 == 0)
                            Console.WriteLine();
                    }
                    Console.WriteLine();
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

        private static bool esteSolutie(int[] sol)
        {
            int sl1 = sol[0] + sol[1] + sol[2];
            int sl2 = sol[3] + sol[4] + sol[5];
            int sl3 = sol[6] + sol[7] + sol[8];
            int sc1 = sol[0] + sol[3] + sol[6];
            int sc2 = sol[1] + sol[4] + sol[7];
            int sc3 = sol[2] + sol[5] + sol[8];
            int sd1 = sol[0] + sol[4] + sol[8];
            int sd2 = sol[6] + sol[4] + sol[2];
            return (sl1 == sl2 && sl2 == sl3
                    && sc1 == sc2 && sc2 == sc3
                    && sd1 == sd2);
        }

        static void Main(string[] args)
        {
            int[] sol = new int[9];
            bool[] b = new bool[9];
            bk(0, 9, sol, b);
        }
    }
}
