using System;
using System.Linq;
 

namespace ConsoleApp1
{
    class Program
    {
        class Node
        {
            int val;
            Node next;
            public Node(int x) { val = x; next = null; }
            public int Val
            {
                get => val;
                set => val = value;
            }
            public Node Next
            {
                get => next;
                set => next = value;
            }
        }
        class List
        {
            Node first;
            int size;
            public List() { first = null; size = 0; }
            public void Add(int x)
            {
                if (first == null) { first = new Node(x); size++; return; }
                Node p = first;
                while (p.Next != null)
                    p = p.Next;
                p.Next = new Node(x);
                size++;
            }
            public int Length
            {
                get => size;                
            }
            public void RemoveAt(int i)
            {
                if (i < 0 || i >= size) throw new Exception("Index out of Range");
                
                size--;
                if (i==0) { first = first.Next; return ; }
                Node p = first, prev=first;
                for (int j = 0; j < i; j++, p = p.Next)
                    prev = p;
                prev.Next = p.Next;
            }
            public int this[int i]
            {
                get
                {
                    if (i < 0 || i >= size) throw new Exception("Index out of Range");
                    Node p = first;
                    for (int j = 0; j < i; j++, p = p.Next)
                       ;
                    return p.Val;
                }
            }
            //public int Pop(int i)
            //{
            //    if (i < 0 || i >= size) throw new Exception("Index out of Range");

 

            //    size--;
            //    int v = first.Val;
            //    if (i == 0) { first = first.Next; return ; }
            //    Node p = first, prev = first;
            //    for (int j = 0; j < i; j++, p = p.Next)
            //        prev = p;
            //    prev.Next = p.Next;
            //}
            public override string ToString()
            {
                string s = "";
                for (Node p = first; p != null; p = p.Next)
                    s += p.Val + " -> ";
                return s;
            }
            public void Sort() { }
            public void Change(int i, int j) { }
            public void Reverse() { }
            public bool Remove(int x) { return true; }
            public bool Find(int x) { return true; }
            public List Copy() { return null; }
            public static List operator +(List l1, List l2) { return null; }
            public static bool operator == (List l1, List l2) { return true; }
            public static bool operator !=(List l1, List l2) { return true; }
        }
        static void Main(string[] args)
        {
            List list = new List();
            //string s = " default";
            //while(s!="")
            //{
            //    s = Console.ReadLine();
            //    if (s == "") break;
            //    int x = int.Parse(s);
            //    list.Add(x);
            //}
            Console.WriteLine(list);
            List[] lists = new List[10];
            for (int i = 0; i < 10; i++)
                lists[i] = new List();
            int[] a = { 561, 344, 23, 18, 90, 165, 877, 1024, 15, 165 };

            int maxval = a.Max();
            int dig = 0;
            while (maxval != 0)
            {
                maxval /= 10;
                dig++;
            }
            
            int count = 0;
            while (count != dig)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    int digit = (a[i] / (Math.Pow(10, count))) % 10;
                    
                }
                count ++;
            }


        }
    }
}