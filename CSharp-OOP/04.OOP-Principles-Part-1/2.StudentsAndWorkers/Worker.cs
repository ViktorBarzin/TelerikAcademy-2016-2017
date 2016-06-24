using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    class Worker : Human
    {
        public Worker(double weekSalary, double workHoursPerDay,string fname,string lname):base(fname,lname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; private set; }

        public double WorkHoursPerDay { get; private set; }

        public double MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }
    }
}
