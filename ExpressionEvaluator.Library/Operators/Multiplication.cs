using ExpressionEvaluator.Library.Interfaces;
namespace ExpressionEvaluator.Library.Operators;
public class Multiplication : IOperator
{
    public char Symbol => '*';
    public int Priority => 2;

    public int Compute(int leftOperand, int rightOperand)
    {
        return leftOperand * rightOperand;
    }
}
