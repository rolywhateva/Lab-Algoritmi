using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platou5
{
    class Program
    {
        //drum in matrice
        //Dimensiunea maxima a unui platou
        static int[,] a;
        static bool[,] b;
        static bool exista = false;
       

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            a = new int[n, m];
            b = new bool[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next() % 2;
                    b[i, j] = false;
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            for (int i = 0; i < n && !exista; i++)
                if (a[i,0]==1&&!b[i, 0])
                {
                    PA(a, i, 0);
                   
                }
            if(!exista)
                Console.WriteLine("NU");
            else
                Console.WriteLine("DA");
           
           // Console.WriteLine(nrmax);
        }

        private static void PA(int[,] a, int i, int j)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i, j]&&a[i,j]==1)
            {
                b[i, j] = true;
                if (j == m - 1)
                {
                    exista = true;
                    return;
                }
                PA(a, i - 1, j);
                PA(a, i, j + 1);
                PA(a, i + 1, j);
                PA(a, i, j - 1);

            }
        }
    }
}
