using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            s = int.Parse(Console.ReadLine());
           
            string line;
            line = Console.ReadLine();
            string[] tokens = line.Split(new char[] { ' ' });
           
           int[] v = new int[tokens.Length];
            int[] r = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
               v[i]= int.Parse(tokens[i]);
             
            }
            int temp = s;
            for(int i=0;i<tokens.Length-1;i++)
                 for(int j=i+1;j<tokens.Length;j++)
                     if(v[i]<v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            for(int i=0;i<tokens.Length;i++)
            {
                r[i] = s / v[i];
                s = s % v[i];
            }
            string rez = temp.ToString() + "=";
            for(int i=0;i<tokens.Length;i++)
            {
                if (r[i] != 0)
                {
                    rez = rez + (r[i] + "*" + v[i]);
                    if (i < tokens.Length - 1)
                        rez = rez + "+";
                }
            }
            Console.WriteLine(rez);
         
           

            
            Console.ReadKey();

        }
    }
}
