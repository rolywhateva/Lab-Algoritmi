using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTL
{
    class Program
    {
        static void Main(string[] args)
        {
            INTL A = new INTL(3333);
            INTL B = new INTL(333);
            INTL C = INTL.Suma(A, B);
            C.Afis();
        }
    }
}
