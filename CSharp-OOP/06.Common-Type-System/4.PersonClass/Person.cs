using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonClass
{
    class Person
    {
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        // Age restriction not specified so leaving auto-property.
        public int? Age { get; private set; }

        public override string ToString()
        {
            return this.Age == null ? this.Name + " age not specified." : this.Name + ' ' + this.Age;
        }
    }
}
