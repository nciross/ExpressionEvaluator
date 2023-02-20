using ExpressionEvaluator.Library.Interfaces;
using ExpressionEvaluator.Library.Operators;
using ExpressionEvaluator.Library.Services;

string[] expressions = {
                "1 + 2",
                "3 * 4",
                "11 - 2",
                "2 * 3 - 1",
                "6 - 2 * 5" };
IOperatorFactory operatorFactory = new OperatorFactory();
var evaluator = new Evaluator(operatorFactory);

foreach (var expression in expressions)
{
    var result = evaluator.Evaluate(expression);
    Console.WriteLine($"{expression} = {result}");
}

Console.ReadLine();