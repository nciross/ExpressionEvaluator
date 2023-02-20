namespace ExpressionEvaluator.Library.Interfaces
{
    public interface IOperatorFactory
    {
        IOperator Create(string symbol);
    }
}
