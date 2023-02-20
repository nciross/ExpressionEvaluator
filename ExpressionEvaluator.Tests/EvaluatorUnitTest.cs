
using ExpressionEvaluator.Library.Interfaces;
using ExpressionEvaluator.Library.Operators;
using ExpressionEvaluator.Library.Services;

namespace ExpressionEvaluator.Tests
{
    public class EvaluatorUnitTest
    {
        private readonly Evaluator _evaluator;
        public EvaluatorUnitTest()
        {
            // Arrange
            IOperatorFactory _operatorFactory = new OperatorFactory();
            _evaluator = new Evaluator(_operatorFactory);
        }
        [Theory]
        [InlineData("1 + 2", 3)]
        [InlineData("3 * 4", 12)]
        [InlineData("11 - 2", 9)]
        [InlineData("2 * 3 - 1", 5)]
        [InlineData("6 - 2 * 5", -4)]
        public void Evaluate_ValidExpression_ReturnsExpectedResult(string expression, int expectedResult)
        {

            // Act
            int result = _evaluator.Evaluate(expression);

            // Assert
            Assert.Equal(expectedResult, result);
        }



        [Fact]
        public void Evaluate_InvalidExpression_ThrowsException()
        {
            // Arrange
            string invalidExpression = "5 5 +";

            // Act and assert
            Assert.Throws<ArgumentException>(() => _evaluator.Evaluate(invalidExpression));
        }

        [Fact]
        public void Evaluate_InvalidOperator_ThrowsException()
        {
            // Arrange
            string invalidExpression = "1 & 2";

            // Act and assert
            Assert.Throws<ArgumentException>(() => _evaluator.Evaluate(invalidExpression));
        }
    }
}