using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab10
{
    public static class Engine
    {
        public static int[,] n;
        public static int x, y, nsx, nsy, nex, ney;
        public static void Load(string fileName)
        {

            List<string> tmp = new List<string>();
            string buffer = " ";
            TextReader dl = new StreamReader(fileName);
            while ((buffer = dl.ReadLine()) != null)
                tmp.Add(buffer);
            x = tmp.Count - 2;
            string[] l = tmp[0].Split(' ');
            y = l.Length;
            n = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                l = tmp[i].Split(' ');
                for (int j = 0; j < y; j++)
                    n[i, j] = int.Parse(l[j]);
            }
            nsx = int.Parse(tmp[tmp.Count - 2].Split(' ')[0]);
            nsy = int.Parse(tmp[tmp.Count - 2].Split(' ')[1]);
            nex = int.Parse(tmp[tmp.Count - 1].Split(' ')[0]);
            ney = int.Parse(tmp[tmp.Count - 1].Split(' ')[1]);
            Console.WriteLine(nsx+" "+nsy + " "+nex + " "+ney);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                    Console.Write(n[i, j] + "\t");
                Console.WriteLine();
             }




        }



    }
}
