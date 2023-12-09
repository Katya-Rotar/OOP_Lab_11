using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Dependency_Inversion
{
    public interface ICalculationStrategy
    {
        int Calculate(int leftOperand, int rightOperand);
    }
}
