using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentd_and_workers
{
    class Worker : Human
    {
        public Worker(String firstname, string lastname,decimal weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return WeekSalary / 7 / WorkHoursPerDay;
        }
    }
}

