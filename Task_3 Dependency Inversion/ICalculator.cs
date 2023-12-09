namespace Task_3_Dependency_Inversion
{
    public delegate int CalculationDelegate(int leftOperand, int rightOperand);
    public interface ICalculator
    {
        event CalculationDelegate StrategyChanged;
        void ChangeStrategy(ICalculationStrategy calculationStrategy);
    }
}
