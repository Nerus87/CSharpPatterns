namespace Patterns
{
    public interface IStrategy { double Calculate(double a, double b); }

    public class Context
    {
        public IStrategy Strategy { get; private set; } = null;

        public Context(IStrategy strategy) { Strategy = strategy; }

        public double DoCalculate(double a, double b) => Strategy.Calculate(a, b);
    }

    public class Add : IStrategy
    {
        public Add() { }

        public double Calculate(double a, double b) => a + b;
    }

    public class Sub : IStrategy
    {
        public Sub() { }

        public double Calculate(double a, double b) => a - b;
    }
}
