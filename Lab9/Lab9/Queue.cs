using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Queue
    {
        int[] v;
        int n; 
        public Queue()
        {
            n = 0;
            v = new int[n];
        }
        public void Add(int val)
        {
            int[] t = new int[++n];
            for (int i = 0; i < n - 1; i++)
                t[i + 1] = v[i];
            t[0] = val;
            v = t;
        }
        public int?  Del()
        {
            if (n == 0)
                return null;
            int tor = v[n - 1];
            n--;
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
                t[i] = v[i];
            v = t;
            return tor;
        }
        public  void Print()
        {
            for(int i=0;i<n;i++)
                Console.Write(v[i]+"\t");
            Console.WriteLine();
        }
    }
}
