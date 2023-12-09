using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Dependency_Inversion.Models
{
    public class Calculator : ICalculator
    {
        private ICalculationStrategy calculationStrategy; //поточна стратегія
        public event CalculationDelegate StrategyChanged;
        public Calculator(ICalculationStrategy calculationStrategy) 
        { //встановлення стратегії
            ChangeStrategy(calculationStrategy);
        }

        public void ChangeStrategy(ICalculationStrategy calculationStrategy) //назва стратегії на зміна її
        {
            this.calculationStrategy = calculationStrategy;
            string[] input = Console.ReadLine().Split(' ');
            int leftOperand = int.Parse(input[0]);
            int rightOperand = int.Parse(input[1]);

            int result = this.calculationStrategy.Calculate(leftOperand, rightOperand);
            Console.WriteLine($"Result: {result}");

            StrategyChanged?.Invoke(leftOperand, rightOperand);
        }
    }
}
