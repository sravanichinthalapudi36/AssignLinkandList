using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssLink
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lList = new LinkedList<string>();
           // lList.AddLast("quick");
            lList.AddLast("fox");
            lList.AddFirst("the");
           // lList.AddLast("lazy");
            Console.WriteLine("-------elements in the linkedlist---------------");
            foreach (var st in lList)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("--------------using Enumerator-------------------");
            LinkedList<string>.Enumerator ll = lList.GetEnumerator();
            while (ll.MoveNext())
            {
                Console.WriteLine(ll.Current);
            }
            var newNode1 = lList.AddFirst("quick");
            lList.AddAfter(newNode1, "brown");
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            var newNode3 = lList.AddLast("jumps");
            lList.AddAfter(newNode3, "over");
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
         
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            var newNode9 = lList.AddLast("lazy");
            lList.AddBefore(newNode9, "the");
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            var newNode = lList.AddLast("fox");
            lList.AddBefore(newNode, "lazy");
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            lList.AddFirst("the");
            
            Console.WriteLine("LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }

        }
    }
}
