using System;
using System.IO;
namespace ProblemaSpectacolelor
{
    class Program
    {
        static void Swap(ref int a,  ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\Spectacole.txt");
            int n =int.Parse( reader.ReadLine());
            Spectacol[] sp = new Spectacol[n];
            for(int i=0;i<n;i++)
            {
               
                string[] tokens = reader.ReadLine().Split(new char[] { ' ', '(', ')', ',' },StringSplitOptions.RemoveEmptyEntries);
                sp[i] = new Spectacol();
                Console.WriteLine(tokens[0]+" "+tokens[1]);
                sp[i].ti = int.Parse(tokens[0]);
               
                sp[i].tf = int.Parse(tokens[1]);

            }
            for(int i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                     if(sp[i].tf>=sp[j].tf)
                    {
                        int aux = sp[i].tf;
                        sp[i].tf = sp[j].tf;
                        sp[j].tf = aux;

                         aux = sp[i].ti;
                        sp[i].ti = sp[j].ti;
                        sp[j].ti = aux;
                        
                       
                            

                    }
            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
                Console.WriteLine(sp[i].ti + " " + sp[i].tf);

            Spectacol t = sp[0];
            int nr = 1;
            string text ="("+ sp[0].ti +","+ sp[0].tf+")";
            for(int i=1;i<n;i++)
                if(sp[i].ti>=t.tf)
                {
                    nr++;
                     text = text + "("+sp[i].ti +"," +sp[i].tf + ")"+"\t";
                    t = sp[i];
                }
            Console.WriteLine("Numarul de spectacole:" + nr);
            Console.WriteLine(text);


           

            Console.ReadKey();
        }
    }
}
