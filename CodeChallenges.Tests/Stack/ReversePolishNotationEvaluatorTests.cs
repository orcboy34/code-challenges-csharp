using CodeChallenges.Stack.ReversePolishNotationEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Tests.Stack
{
    public class ReversePolishNotationEvaluatorTests
    {
        public static IEnumerable<object[]> Evaluators =>
        [
            [new ReversePolishNotationEvaluator()]
        ];

        [Theory]
        [MemberData(nameof(Evaluators))]
        public void ReversePolishNotationEvaluator_ReturnsCorrectValue_WithSingleAddition(IReversePolishNotationEvaluator evaluator)
        {
            //Arrange
            string[] tokens = ["2", "1", "+"];

            //Act
            var result = evaluator.Evaluate(tokens);

            //Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [MemberData(nameof(Evaluators))]
        public void ReversePolishNotationEvaluator_ReturnsCorrectValue_WithSingleSubtraction(IReversePolishNotationEvaluator evaluator)
        {
            //Arrange
            string[] tokens = ["20", "15", "-"];

            //Act
            var result = evaluator.Evaluate(tokens);

            //Assert
            Assert.Equal(5, result);
        }

        [Theory]
        [MemberData(nameof(Evaluators))]
        public void ReversePolishNotationEvaluator_ReturnsCorrectValue_WithSingleMultiplication(IReversePolishNotationEvaluator evaluator)
        {
            //Arrange
            string[] tokens = ["6", "7", "*"];

            //Act
            var result = evaluator.Evaluate(tokens);

            //Assert
            Assert.Equal(42, result);
        }

        [Theory]
        [MemberData(nameof(Evaluators))]
        public void ReversePolishNotationEvaluator_ReturnsCorrectValue_WithSingleDivision(IReversePolishNotationEvaluator evaluator)
        {
            //Arrange
            string[] tokens = ["96", "4", "/"];

            //Act
            var result = evaluator.Evaluate(tokens);

            //Assert
            Assert.Equal(24, result);
        }

        [Theory]
        [MemberData(nameof(Evaluators))]
        public void ReversePolishNotationEvaluator_ReturnsCorrectValue_WithMultipleOperations(IReversePolishNotationEvaluator evaluator)
        {
            //Arrange
            string[] tokens = ["96", "4", "/", "1", "+", "4", "*", "40", "-"];

            //Act
            var result = evaluator.Evaluate(tokens);

            //Assert
            Assert.Equal(60, result);
        }
    }
}
