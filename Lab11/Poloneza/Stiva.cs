using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poloneza
{
    class Stiva
    {
        string[] values;
        public int n;
        public Stiva()
        {
            n = 0;
            values = new string[n];
        }
        public void Add(string value)
        {
            n++;
            string[] temp = new string[n];
            for (int i = 0; i <n-1; i++)
                temp[i] = values[i];
            temp[n-1] = value;
            values = temp;
        }
        public string Pop()
        {
            if (n < 1)
                return null;
            string toReturn = values[n-1];
            string[] temp = new string[--n];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = values[i];
            values = temp;
            return toReturn;
        }
        public void View()
        {
            for (int i = 0; i < n; i++)
                Console.Write(values[i] + "\t");

        }
    }
}
