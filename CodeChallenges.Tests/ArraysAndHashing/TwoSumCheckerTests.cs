
using CodeChallenges.ArraysAndHashing.TwoSum;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class TwoSumCheckerTestsBase
    {
        public static IEnumerable<object[]> Checkers =>
        [
            [new BruteForceTwoSumChecker()],
            [new SortingTwoSumChecker()],
            [new SinglePassHashMapTwoSumChecker()],
            [new TwoPassHashMapTwoSumChecker()]
        ];

        [Theory]
        [MemberData(nameof(Checkers))]
        public void TwoSum_WithDistinctElements_ReturnsCorrectIndices(ITwoSumChecker checker)
        {
            // Arrange
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            // Act
            var result = checker.TwoSum(nums, target);
            // Assert
            Assert.Equal([0, 1], result);
        }

        [Theory]
        [MemberData(nameof(Checkers))]
        public void TwoSum_WithDuplicateElements_ReturnsCorrectIndices(ITwoSumChecker checker)
        {
            // Arrange
            var nums = new int[] { 3, 2, 5, 3 };
            var target = 6;
            // Act
            var result = checker.TwoSum(nums, target);
            // Assert
            Assert.Equal([0, 3], result);
        }

        [Theory]
        [MemberData(nameof(Checkers))]
        public void TwoSum_WithNegativeNumbers_ReturnsCorrectIndices(ITwoSumChecker checker)
        {
            // Arrange
            var nums = new int[] { -3, 4, 3, 9 };
            var target = 0;
            // Act
            var result = checker.TwoSum(nums, target);
            // Assert
            Assert.Equal([0, 2], result);
        }
    }
}
