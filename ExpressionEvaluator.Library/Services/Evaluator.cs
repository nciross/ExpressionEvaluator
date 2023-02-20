using ExpressionEvaluator.Library.Interfaces;
namespace ExpressionEvaluator.Library.Services;
public class Evaluator
{
    private readonly IOperatorFactory _operatorFactory;
    public Evaluator(IOperatorFactory operatorFactory)
    {
        _operatorFactory = operatorFactory;
    }
    public int Evaluate(string expression)
    {
        var tokens = expression.Split(' ');

        var valueStack = new Stack<int>();
        var operatorStack = new Stack<IOperator>();

        for (int i = 0; i < tokens.Length; i++)
        {
            string token = tokens[i];
            if (int.TryParse(token, out int value))
            {
                valueStack.Push(value);
            }
            else
            {
                IOperator op = _operatorFactory.Create(token);
                while (operatorStack.Count > 0 && operatorStack.Peek().Priority >= op.Priority)
                {
                    IOperator prevOp = operatorStack.Pop();
                    int b = valueStack.Pop();
                    int a = valueStack.Pop();
                    int result = prevOp.Compute(a, b);
                    valueStack.Push(result);
                }
                operatorStack.Push(op);
            }
        }

        while (operatorStack.Count > 0)
        {
            IOperator op = operatorStack.Pop();
            int b = valueStack.Pop();
            int a = valueStack.Pop();
            int result = op.Compute(a, b);
            valueStack.Push(result);
        }

        return valueStack.Pop();
    }
}
