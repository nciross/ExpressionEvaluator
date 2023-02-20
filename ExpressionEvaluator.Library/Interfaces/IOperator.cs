namespace ExpressionEvaluator.Library.Interfaces
{
    public interface IOperator
    {
        int Priority { get; }
        int Compute(int leftOperand, int rightOperand);
    }

  

   

   
}
