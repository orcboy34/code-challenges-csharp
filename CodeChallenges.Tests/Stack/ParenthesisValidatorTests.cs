using CodeChallenges.Stack.ValidParentheses;

namespace CodeChallenges.Tests.Stack
{
    public class ParenthesisValidatorTests
    {
        public static IEnumerable<object[]> Validators => [
            [new ParenthesisValidator()]
        ];

        [Theory]
        [MemberData(nameof(Validators))]
        public void ParenthesisValidator_ReturnsTrue_WithValidInput(IParenthesesValidator validator)
        {
            //Arrange
            var input = "[{()}[]]()";

            //Act
            var result = validator.Validate(input);

            //Assert
            Assert.True(result);
        }

        //Here we test if the validator can detect out of sequence pairs.
        [Theory]
        [MemberData(nameof(Validators))]
        public void ParenthesisValidator_ReturnsFalse_WithMalformedInput(IParenthesesValidator validator)
        {
            //Arrange
            var input = "[{([)]}]()";

            //Act
            var result = validator.Validate(input);

            //Assert
            Assert.False(result);
        }

        //Here we test if the validator can detect an unclosed paren.
        [Theory]
        [MemberData(nameof(Validators))]
        public void ParenthesisValidator_ReturnsFalse_WithDanglingOpener(IParenthesesValidator validator)
        {
            //Arrange
            var input = "[{()}](";

            //Act
            var result = validator.Validate(input);

            //Assert
            Assert.False(result);
        }
    }
}
