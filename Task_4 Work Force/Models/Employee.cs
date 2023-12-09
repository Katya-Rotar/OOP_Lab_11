using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Work_Force.Models
{
    public abstract class Employee
    {
        protected Employee(string name, int hoursPerWeek)
        {
            Name = name;
            HoursPerWeek = hoursPerWeek;
        }

        public int HoursPerWeek { get; private set; }

        public string Name { get; private set; }
    }
}
