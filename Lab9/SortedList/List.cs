using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
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
        private  void AddBeg(int v)
        {
            Node nou = new Node(v);
            nou.next = cap;
            cap = nou;

        }
        private  void AddEnd(int v)
        {
            if (this == null)
                AddBeg(v);
            Node ct;
            for (ct = cap; ct.next != null; ct = ct.next) ;
            Node nou = new Node(v);
            ct.next = nou;

        }
        public void Add(int v)
        {
            if (cap == null)
            {
                AddBeg(v);
                return;
            }
            else
                 if (cap.next == null)
                    if (v<cap.Value)
                    {
                        AddBeg(v);
                        return;
                    }
                    else
                    {
                        AddEnd(v);
                        return;
                    }
            if (v < cap.Value)
            {
                AddBeg(v);
                return;
            }
            Node ct = cap;
           
            while (ct.next!=null&&v>ct.next.Value)
                ct = ct.next;
            Node nou = new Node(v);
            nou.next = ct.next;
            ct.next = nou;



        }
        public void Print()
        {
            Node v = cap;

            while (v != null)
            {
                Console.Write(v.Value + "\t");
                v = v.next;
            }
            Console.WriteLine();

        }

    }
}
