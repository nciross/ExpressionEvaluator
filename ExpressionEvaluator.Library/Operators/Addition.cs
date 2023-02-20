using ExpressionEvaluator.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionEvaluator.Library.Operators;
public class Addition : IOperator
{
    public char Symbol => '+';
    public int Priority => 1;

    public int Compute(int leftOperand, int rightOperand)
    {
        return leftOperand + rightOperand;
    }
}
