using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue coada = new Queue();
            for (int i = 0; i < 10; i++)
                coada.Add(i);
            coada.Print();
            coada.Del();
            coada.Print();
        }
    }
}
