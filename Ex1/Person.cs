using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Output()
        {
            Console.WriteLine("Name: "+Name + " Age: " + Age);
        }
    }

}
