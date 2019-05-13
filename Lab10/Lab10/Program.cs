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
            Queue q = new Queue();
            for (int i = 0; i < 10; i++)
            {
               // q.Add(i);
                q.Afis();
                Console.WriteLine();
            }
            q.Afis();
            q.Remove();
            q.Remove();
            Console.WriteLine();
            q.Afis();
        }
    }
}
