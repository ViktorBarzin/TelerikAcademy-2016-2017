using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    abstract class Animal : ISound
    {
        protected Animal(int age, string name, Sex sexType)
        {
            this.Age = age;
            this.Name = name;
            this.SexType = sexType;
        }

        public int Age { get;private set; }

        public string Name { get; private set; }

        public Sex SexType { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
