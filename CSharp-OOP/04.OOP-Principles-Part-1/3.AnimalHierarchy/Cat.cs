using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(int age, string name, Sex sexType) : base(age, name, sexType)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat sound");
        }
    }
}
