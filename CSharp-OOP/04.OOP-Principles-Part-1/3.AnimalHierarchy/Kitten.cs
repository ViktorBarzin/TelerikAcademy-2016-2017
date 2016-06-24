using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(int age, string name) : base(age, name, Sex.Female)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kitten sound");
        }
    }
}
