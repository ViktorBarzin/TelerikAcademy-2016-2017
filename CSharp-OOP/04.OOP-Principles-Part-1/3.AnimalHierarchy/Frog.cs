using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(int age, string name, Sex sexType) : base(age, name, sexType)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Frog sound");
        }
    }
}
