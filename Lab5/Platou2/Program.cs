using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platou2
{
    class Program
    {
        static int[,] a;
        static bool b1, b2;
        static bool[,] b;
        static int nr;
       
      static void PI(int[,] a, int i, int j)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            if (i >= 0 && j >= 0 && i < n && j < m&& !b[i, j]  )
            {
                b[i, j] = true;
           
                if (a[i, j] == 0)
                {
                    nr++;

                    PI(a, i - 1, j);
                    PI(a, i, j + 1);
                    PI(a, i + 1, j);
                    PI(a, i, j - 1);

                }
                else
                     if (a[i, j] == 1)
                    b1 = true;
                else
                    if(a[i,j]==2)
                    b2 = true;
          
            }
        }
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
                  b[i,j]= false;
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            int t1, t2;
            t1 = t2 = 0;
            for(int i=0;i<n;i++)
               for(int j=0;j<m;j++)
                {
                  if(a[i,j]==0&&!b[i,j])
                    {
                        nr = 0;
                        b1 = b2 = false;
                       
                        PI(a, i, j);

                        if (b1 && !b2)
                        {
                          
                            t1 = t1 + nr;
                        }
                        if (!b1 && b2)
                        {
                          
                           
                            t2 = t2 + nr;
                        }
                    }
                    

                }
            Console.WriteLine("t1:{0} t2:{1}", t1, t2);
        }
    }
}
