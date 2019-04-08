using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void  hanoi(int n, char A, char B, char C)
        {
            if (n == 1)
                Console.WriteLine(A + "->" + C);
            else
            {
                hanoi(n - 1, A, C, B);
                hanoi(1, A, B, C);
                hanoi(n - 1, B, A, C);
            }
        }
        static void hanoi2(int n, char A,char B, char C, char D)
        {
            if (n == 1)
                Console.WriteLine(A + "->" + D);
            else 
                 if(n==2)
            {
                Console.WriteLine(A + "->" + B);
                Console.WriteLine(A + "->" + D);
                Console.WriteLine(B + "->" + D);
            }else
            {
                hanoi2(n - 2, A, C, D, B);
                hanoi2(1, A, B, D, C);
                hanoi2(1, A, B, C, D);
                hanoi2(1, C, A, B, D);
                hanoi2(n - 2, B, A, C, D);
            }
        }
        static void Main(string[] args)
        {
            //  hanoi(3, 'A', 'B', 'C');
            hanoi2(3, 'F', 'U', 'C', 'K');
        }
    }
}
