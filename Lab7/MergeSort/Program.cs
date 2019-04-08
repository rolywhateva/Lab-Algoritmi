using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static int[] Merge(int[] st, int[] dr)
        {
            int i1, i2, i3;
            int[] v = new int[st.Length + dr.Length];
            i1 = i2 = i3 = 0;
            while(i1<st.Length&&i2<dr.Length)
            {
                if (st[i1] < dr[i2])
                    v[i3++] = st[i1++];
                else
                    v[i3++] = dr[i2++];
            }
            while(i1<st.Length)
                v[i3++] = st[i1++];
            while (i2 < dr.Length)
                v[i3++] = dr[i2++];
            return v;
            
        }
        static int[] MergeSort(int[] a)
        {
            if (a.Length == 1) return a;
            else
            {
                int m = a.Length / 2;
                int[] left = new int[m];
                int[] right;
                if (a.Length % 2 != 0)
                    right = new int[m + 1];
                else
                    right = new int[m];
                for (int i = 0; i < m; i++)
                    left[i] = a[i];
                int k = 0;
                for (int i = m; i < a.Length; i++)
                    right[k++] = a[i];
                left = MergeSort(left);
                right = MergeSort(right);
                int[] r = new int[a.Length];

                r = Merge(left, right);
                return r;
            }

            
        }
        static void Main(string[] args)
        {

           int[] r =  MergeSort(new int[] { -2, -3, 0, 0, 0, 0, 1, -5, 6, 7, -3, 4, 0, -10, 2, 3, 4, -3 });
            Console.WriteLine(string.Join("  ",r));
        }
    }
}
