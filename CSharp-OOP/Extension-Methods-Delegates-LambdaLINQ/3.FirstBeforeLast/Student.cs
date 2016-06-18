using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using _9.StudentGroups;

namespace _3.FirstBeforeLast
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        // check if FN can be stored in int
        public int Fn { get; set; }

        public string Email { get; set; }

        public List<Mark> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }
    }
}
