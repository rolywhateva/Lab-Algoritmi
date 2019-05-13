using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List l = new List();
            Random rnd = new Random();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    l.Add(rnd.Next(-25,25));

                }
                l.Print();
            }
         
            
        }
    }
}
