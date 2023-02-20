namespace ExpressionEvaluator.Library.Interfaces
{
    public interface IOperator
    {
        char Symbol { get; }
        int Priority { get; }
        int Compute(int leftOperand, int rightOperand);
    }

  

   

   
}
