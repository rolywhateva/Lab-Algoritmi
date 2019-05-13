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
            n++;
            Data[] t = new Data[n];
            for (int i = 0; i < n - 1; i++)
                t[i+1] = v[i];
            t[0] = data;
            v = t;
        }
        public Data Remove()
        {
          
                Data r = v[n - 1];
                n--;
                Data[] t = new Data[n];
                for (int i = 0; i < n; i++)
                    t[i] = v[i];
                v = t;
                
                return r;
            
            
        }
        public  string Afis()
        {
            string buffer = "";
            for (int i = 0; i < n; i++)
                buffer += v[i].View() + " ";
            return buffer;
        }
        
    }
}
