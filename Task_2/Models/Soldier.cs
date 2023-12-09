using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public abstract class Soldier
    {
        public Soldier(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public abstract void RespondToAttack();
    }
}
