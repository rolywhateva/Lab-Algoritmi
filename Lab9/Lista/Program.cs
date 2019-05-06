using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.AddBeg(5);
            for (int i = 0; i < 11; i++)
                list.AddEnd(i);
            list.Print();
            Console.WriteLine(list.delmid());
            list.addmid(100);
            list.Print();
            Console.WriteLine();
            list.Modifica(3, 2345);
            list.Print();
        }
    }
}
