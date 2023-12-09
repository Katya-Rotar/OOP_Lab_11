using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Work_Force.Models
{
    internal class StandardEmployee : Employee
    {
        public StandardEmployee(string name, int hoursPerWeek) 
            : base(name, 40)
        {
        }
    }
}
