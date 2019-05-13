using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTL
{
    class INTL
    {
        int n;
        int[] v;
        public INTL()
        {
            n = 0;
            v = new int[n];

        }
        public INTL(int n)
        {
            if (n == 0)
                Add(0);
            else
            {
                while(n!=0)
                {
                    Add(n % 10);
                    n /= 10;
                }

            }
        }
        public void Afis()
        {
            for(int i=0;i<n;i++)
                Console.Write(v[i]);
            Console.WriteLine();
        }
        public  void Add(int x)
        {
            n++;
            int[] t = new int[n];
            for (int i = 0; i < n - 1; i++)
                t[i + 1] = v[i];
            v = t;
            
        }
        public void Inv()
        {
            for(int i=0;i<n/2;i++)
            {
                int aux = v[i];
                v[i] = v[n - 1 - i];
                v[n - 1 - i] = aux;
            }
        }
        public static INTL Suma(INTL A, INTL B)
        {
            A.Inv();
            B.Inv();
            int i = 0, t = 0;
            INTL C = new INTL();
            while(i<A.n&&i<B.n)
            {
                C.Add((A.v[i] + B.v[i] + t) % 10);
                t = (A.v[i] + B.v[i] + t) / 10;
                i++;
            }
            while(i<A.n)
            {
                C.Add((A.v[i]  + t) % 10);
                t = (A.v[i] +t) / 10;
                i++;

            }
            while (i < B.n)
            {
                C.Add((B.v[i] +t) % 10);
                t = (B.v[i]+t) / 10;
                i++;

            }
            if (t != 0)
                C.Add(t);
            return C;


        }
        
    }
}
