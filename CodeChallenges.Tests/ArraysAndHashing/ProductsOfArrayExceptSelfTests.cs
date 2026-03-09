using CodeChallenges.ArraysAndHashing.ProductsOfArrayExceptSelf;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class ProductsOfArrayExceptSelfTests
    {
        public static IEnumerable<object[]> Calculators => [
            [new BruteForceProductsOfArrayExceptSelfCalculator()],
            [new DivisionProductsOfArrayExceptSelfCalculator()],
            [new PrefixAndSuffixProductsOfArrayExceptSelfCalculator()],
        ];

        [Theory]
        [MemberData(nameof(Calculators))]
        public void ProductsOfArrayExceptSelf_WithNoZeroes_CalculatesProducts(IProductsOfArrayExceptSelfCalculator calculator)
        {
            //Arrange
            int[] input = [1, 2, 4, 6];

            //Act
            var result = calculator.Calculate(input);

            //Assert
            Assert.Equal([48, 24, 12, 8], result);
        }

        [Theory]
        [MemberData(nameof(Calculators))]
        public void ProductsOfArrayExceptSelf_WithOneZero_CalculatesProducts(IProductsOfArrayExceptSelfCalculator calculator)
        {
            //Arrange
            int[] input = [-1, 0, 1, 2, 3];

            //Act
            var result = calculator.Calculate(input);

            //Assert
            Assert.Equal([0, -6, 0, 0, 0], result);
        }

        [Theory]
        [MemberData(nameof(Calculators))]
        public void ProductsOfArrayExceptSelf_WithTwoZeroes_CalculatesAllZeroes(IProductsOfArrayExceptSelfCalculator calculator)
        {
            //Arrange
            int[] input = [-10, 0, 21, 32, 43, 0];

            //Act
            var result = calculator.Calculate(input);

            //Assert
            Assert.Equal([0, 0, 0, 0, 0, 0], result);
        }
    }
}
