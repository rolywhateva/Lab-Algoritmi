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

            

        }



    }
}
