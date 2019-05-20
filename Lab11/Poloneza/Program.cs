using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Poloneza
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Dati expresia:");
            string expresie =@""+ Console.ReadLine();
            string[] tokens = expresie.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
          
            Stiva stack = new Stiva();
            List<string> operators = new List<string>(new string[] { "+", "-", "*", "/" });
            Console.WriteLine(string.Join(" ", operators.ToArray()));
            for (int i=0;i<tokens.Length;i++)
            {
                if(!operators.Contains(tokens[i]))
                {
                    bool success = int.TryParse(tokens[i], out int toAdd);
                    if(success==false)
                    {
                        Console.WriteLine(tokens[i]);
                        Console.WriteLine("Ilegal1");
                        return;
                    }
                    stack.Add(tokens[i]);
                }
                else
                {
                    int op1 = int.Parse(stack.Pop());
                    int op2 = int.Parse(stack.Pop());
                    int? rez = Rezultat(op2, op1, tokens[i]);
                    if(rez==null)
                    {
                        Console.WriteLine(tokens[i]);
                        Console.WriteLine("Ilegal2");
                        return;
                    }
                    stack.Add(rez.ToString());
                }
                    

            }
            stack.View();

        }

        private static int? Rezultat(int op1, int op2, string v)
        {
            switch(v)
            {
                case "+": return op1 + op2 ;
                case "-":return op1 - op2;
                case "*":return op1 * op2;
                case "/":return op1 / op2;
                default: return null;
            }
        }
    }
}
