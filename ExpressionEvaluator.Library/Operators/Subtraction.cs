﻿using ExpressionEvaluator.Library.Interfaces;
namespace ExpressionEvaluator.Library.Operators;
public class Subtraction : IOperator
{
    public char Symbol => '-';
    public int Priority => 1;

    public int Compute(int leftOperand, int rightOperand)
    {
        return leftOperand - rightOperand;
    }
}
