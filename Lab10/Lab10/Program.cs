using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.Load(@"..\..\labirint.in");
            Queue A = new Queue();
            A.Add(Engine.nsx, Engine.nsy, 1);
            Engine.n[Engine.nsx, Engine.nsy] = 1;
            while(A.n>0)
            {
                Data tod = A.Remove();
                int x = tod.x;
                int y = tod.y;
                int v = tod.v;
                if(x-1>=0&&Engine.n[x-1,y]==0)
                {
                    A.Add(x - 1, y, v + 1);
                    Engine.n[x - 1, y] = v + 1;
                }
                if (x + 1 < Engine.x && Engine.n[x +1, y] == 0)
                {
                    A.Add(x +1, y, v + 1);
                    Engine.n[x + 1, y] = v + 1;
                }
                if (y - 1 >= 0 && Engine.n[x , y-1] == 0)
                {
                    A.Add(x , y-1, v + 1);
                    Engine.n[x, y-1] = v + 1;
                }
                if (y + 1<Engine.y && Engine.n[x , y+1] == 0)
                {
                    A.Add(x , y+1, v + 1);
                    Engine.n[x , y+1] = v + 1;
                }


            }
            Console.WriteLine(Engine.n[Engine.nex, Engine.ney]);
        }
    }
}
