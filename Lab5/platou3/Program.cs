using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platou3
{
    class Program
    {
        static int[,] a;
        static bool[,] b;
        static int nr;
        static int lg;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            a = new int[n, m];

            b = new bool[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next() % 3;
                    b[i, j] = false;
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            int nr = 0;
            for(int i=0;i<n;i++)
                for(int j=0;j<m;j++)
                     if(!b[i,j])
                    {
                      
                        lg = 0;
                        PA(a, i, j,a[i,j]);
                        if (lg > 1)
                            nr++;

                    }
            Console.WriteLine(nr);
        }

        private static void PA(int[,] a, int i, int j,int t )
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i, j])
            {
                b[i, j] = true;
                lg++;
                if (a[i, j] == t)
                {
                   

                    PA(a, i - 1, j,t);
                    PA(a, i, j + 1,t);
                    PA(a, i + 1, j,t);
                    PA(a, i, j - 1,t);

                }
             
            }
        }
    }
}
