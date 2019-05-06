using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class List
    {
        class Node
        {
            public int Value;
            public Node next;
            public Node(int Value)
            {
                this.Value = Value;
                next = null;
            }
            public Node()
            {
                next = null;
            }
        }
        Node cap;
      
        public List()
        {
            cap = null;
        }
        public  void AddBeg(int v)
        {
            Node nou = new Node(v);
            nou.next = cap;
            cap = nou;

        }
        public void AddEnd(int v)
        {
            if (this == null)
                AddBeg(v);
            Node ct;
            for ( ct = cap; ct.next != null; ct = ct.next) ;
            Node nou = new Node(v);
            ct.next = nou;

        }
        public void Print()
        {
            Node v = cap;
           
            while(v!=null)
            {
                Console.Write(v.Value+"\t");
                v = v.next;
            }

        }
        public int? Delbeg()
        {
            if (cap == null)
                return null;
            int aux = cap.Value;
            cap = cap.next;
            return aux;
        }
        public int? delend()
        {
            if (cap == null)
                return null;

            Node ct = cap;
            while (ct.next.next != null)
                ct = ct.next;
            int aux = ct.next.Value;
            ct.next = null;
            return aux;
        }
        public int Count()
        {
            int nr = 0;
            Node ct = cap;
            while(ct!=null)
            {
                nr++;
                ct = ct.next;
            }
            return nr;

        }
        public int? delmid()
        {
            if (cap == null)
                return null;
            int n = Count();
            int i = 0;
            Node ct = cap;
            while(i<n/2-1&&ct!=null)
            {
                i++;
                ct = ct.next;
            }
            int val = ct.next.Value;
            ct.next = ct.next.next;
            return val;

        }
        public void addmid(int val)
        {
            if (cap == null)
                AddBeg(val);
            int n = Count();
            int i = 0;
            Node ct = cap;
            while (i < n / 2 - 1 && ct != null)
            {
                i++;
                ct = ct.next;
            }
            Node nou = new Node(val);
            nou.next = ct.next;
            ct.next = nou;
        }
        public void Modifica(int poz, int val)
        {
            if (cap == null)
                return;
            
            Node ct = new Node();
            ct = cap;
            int i = 0;
            while(i< poz&&ct!=null)
            {
                i++;
                ct = ct.next;
            }
            if (ct == null && poz > i)
                return;
            else
                ct.Value = val;



        }


    }
}
