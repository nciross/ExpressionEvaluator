using ExpressionEvaluator.Library.Interfaces;
namespace ExpressionEvaluator.Library.Operators;
public class OperatorFactory : IOperatorFactory
{
    public IOperator Create(string symbol)
    {
        switch (symbol)
        {
            case "+":
                return new Addition();
            case "-":
                return new Subtraction();
            case "*":
                return new Multiplication();
            default:
                throw new ArgumentException($"Invalid operator: {symbol}");
        }
    }
}
