using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Queue
    {
       public  int n;
        public Data[] v;
        public Queue()
        {
            n = 0;
            v = new Data[n];

        }
        public void Add(int x,int y, int z)
        {
            Data data = new Data(x, y, z);
            Data[] t = new Data[++n];
            for (int i = 1; i < n - 1; i++)
                t[i] = v[i - 1];
            t[0] = data;
            v = t;
        }
        public Data Remove()
        {
            if (n > 0)
            {
                Data r = v[n - 1];
                n--;
                Data[] t = new Data[n];
                for (int i = 0; i < n; i++)
                    t[i] = v[i];
                v = t;
                
                return r;
            }
            return new Data(-1, -1, -1);
        }
        public  string Afis()
        {
            string buffer = " ";
            for (int i = 0; i < n; i++)
                buffer += v[i].View() + "\n";
            return buffer;
        }
        
    }
}
