using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person
    {
        public string Name { get; set; }
        private int Age  { get; set; }
        public string Address { get; set; }

        public Child[] Children { get; set; }

        public Person(int age)
        {
            Age = age;
        }

    }

    public class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
