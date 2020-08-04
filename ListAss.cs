using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Http.Headers;

namespace AssLink
{
    class ListAss
    {
        class Person
        {
            int age;
            string fname;
            string lname;
            string city;

            public Person()
            {

            }
            public Person  (int _age, string _fname, string _lname, string _city)
            {
                this.age = _age;
                this.fname = _fname;
                this.lname = _lname;
                this.city = _city;
            }
            public void Displayperson()
            {
                Console.WriteLine("age :{0},firstname :{1},last name :{0},city:{0}", age,fname,lname,city);
                

            }
        }
        static void Main()
        {
            List<Person> Per = new List<Person>();
            Person per1 = new Person(21, "sravs", "ch", "pdrl");
            Person per2 = new Person(22, "balu", "ch", "pdrl");
            Person per3 = new Person(23, "appu", "ch", "pdrl");
            Person per4 = new Person(24, "phani", "p", "chilaru");
            Person per5 = new Person(25, "reethu", "r", "eluru");

            Per.Add(per1);
            Per.Add(per2);
            Per.Add(per3);
            Per.Add(per4);
            Per.Add(per5);


            foreach (Person p in Per)
            {
                // Console.WriteLine(p.fname);
                p.Displayperson();
            }       
            


        }
    }
}
