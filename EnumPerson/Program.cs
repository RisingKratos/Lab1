using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public enum Genders : int {Male, Female};
    struct Person
    {
        public string name;
        public string surName;
        public int age;
        public Genders gender;
        public Person(string Name, string SurName, int Age,Genders Gender)
        {
            name = Name;
            surName = SurName;
            age = Age;
            gender = Gender;
        }
        public override string ToString()
        {
            return name + ' ' + surName + ", age: " + age + ", sex: " + gender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Muslim", "Beibytuly", 18, Genders.Male);
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
