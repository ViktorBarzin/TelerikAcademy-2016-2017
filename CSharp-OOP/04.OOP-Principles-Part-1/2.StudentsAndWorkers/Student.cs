using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    class Student : Human
    {
        public Student(double grade,string fname,string lname):base(fname,lname)
        {
            this.Grade = grade;
        }

        public double Grade { get;private set; }

    }
}
