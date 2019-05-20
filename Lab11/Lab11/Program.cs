using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab11
{
    class Program
    {
        static void switchval(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        static void switchnodes(int[,] m, int nod1,int nod2)
        {
            
            int n = m.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                switchval(ref m[nod1, i], ref m[nod2, i]);
                switchval(ref m[i, nod1], ref m[i, nod2]);
            }
                
        }
        static int grad(int[,] m, int nod1)
        {
            int n = m.GetLength(0);
            int grad = 0;
            for (int i = 0; i < n; i++)
                grad = grad + m[nod1, i];
            return grad;

        }
        static void Main(string[] args)
        {
            int n;
            int[,] m;
            List<string> nod = new List<string>();
            using (StreamReader reader = new StreamReader(@"..\..\Graf.txt"))
            {
                string[] tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                n = int.Parse(tokens[0]);
                m = new int[n, n];
                string line; 
                while((line = reader.ReadLine())!=null)
                {
                    tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int nod1 = int.Parse(tokens[0]);
                    int nod2 = int.Parse(tokens[1]);
                    nod.Add(nod1 + " " + nod2);
                    m[nod1, nod2] = m[nod2, nod1] = 1;

                }
            }
            Console.WriteLine(string.Join("\n", nod.ToArray()));
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,3}",m[i,j]);
                Console.WriteLine();
            }
            int nodmax = 0;
            for (int i = 1; i < n; i++)
                if (grad(m, i) > grad(m, nodmax))
                    nodmax = i;
            switchnodes(m, 0, nodmax);

            int[] c  = new int[n];
            for (int i = 0; i < c.Length; i++)
                c[i] = -1;
            for(int i=0;i<n;i++)
            {
                bool[] col = new bool[n];
                for (int j = 0; j < n; j++)
                    if (i != j && m[i, j] == 1)
                        if (c[j] != -1)
                            col[c[j]] = true;
                for(int k=0;k<n;k++)
                     if(col[k]==false)
                    {
                        c[i] = k;
                        break;
                    }
            }
            Console.WriteLine(string.Join(" ",c));
        }
            
        }
    }

