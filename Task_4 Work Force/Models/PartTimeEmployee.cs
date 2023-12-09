using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Work_Force.Models
{
    internal class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, int hoursPerWeek) 
            : base(name, 20)
        {
        }
    }
}
