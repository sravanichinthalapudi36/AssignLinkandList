using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AssLink
{
    class Que1
    {
        static void Main()
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] { "quick", "fox", "the", "lazy" });
            string s = "";
            Console.WriteLine("--------------------Adding String n the First-----------------");
            lList.AddFirst("the");
            foreach(var st in lList)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("---------------------Inserted fox on the last-----------------");
            lList.AddLast("fox");
            foreach (var st in lList)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("-----------------using find to AddAfter for brown-----------------");
            var newNode = lList.Find("quick");
            lList.AddAfter(newNode, "brown");
            foreach (var st in lList)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("------------------jumps before the using ADDLast----------------------");
            var newNode2 = lList.FindLast("the");
            lList.AddBefore(newNode2, "jumps");
            lList.AddBefore(newNode2, "over");
            foreach (var st in lList)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("-------------------Final Output-----------------------------------------");
            foreach (var st in lList)
            {
                s += st + " ";
            }
            Console.WriteLine(s);
        }
    }
}
