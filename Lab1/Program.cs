using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    struct Person
    {
        public string name;
        public string surName;
        public int age;
        public Person(string Name, string SurName, int Age)
        {
            name = Name;
            surName = SurName;
            age = Age;
        }
        public override string ToString()
        {
            return name + ' ' + surName + ", age: " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Muslim","Beibytuly",18);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
