using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SchoolClasses
{
    abstract class School
    {
        public Class Class { get; private set; }

        public string Comment { get; set; }
    }
}
