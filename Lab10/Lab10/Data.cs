using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Data
    {
        public int x, y, v;
        public  Data(int x, int y, int v)
        {
            this.x = x;
            this.y = y;
            this.v = v;
        }
        public Data(Data data)
        {
            x = data.x;
            y = data.y;
            v = data.v;
        }
        public string View()
        {
            return x + " " + y + " " + v+" ";
        }
    }
}
