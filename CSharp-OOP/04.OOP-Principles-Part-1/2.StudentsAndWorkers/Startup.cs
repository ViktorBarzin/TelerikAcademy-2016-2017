using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    class Startup
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = new List<Student>(10);
            var sortedStudentsByGrade = students.OrderBy(x => x.Grade).ToList();

            IEnumerable<Worker> workers = new List<Worker>(10);
            var sortedWorkersByMoneyByHour = workers.OrderBy(x => x.MoneyPerHour()).ToList();

            var workersAndStudents = new List<Human>(students.Count() + workers.Count());
            workersAndStudents.AddRange(workers);
            workersAndStudents.AddRange(students);

            var sortedWorkersAndStudentsByName = workersAndStudents.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }
    }
}
