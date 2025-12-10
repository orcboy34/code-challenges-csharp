using CodeChallenges.ArraysAndHashing.DuplicateCheckers;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class DuplicateCheckerTests
    {
        public static IEnumerable<object[]> Checkers =>
        [
            [new BruteForceDuplicateChecker()],
            [new SortingDuplicateChecker()],
            [new HashSetDuplicateChecker()],
            [new HashSetLengthDuplicateChecker()]
        ];

        [Theory]
        [MemberData(nameof(Checkers))]
        public void ContainsDuplicate_WithDuplicateValues_ReturnsTrue(IDuplicateChecker checker)
        {
            //Arrange
            var nums = new[] { 1, 2, 3, 3 };

            //Act
            var result = checker.ContainsDuplicate(nums);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(Checkers))]
        public void ContainsDuplicate_WithoutDuplicateValues_ReturnsFalse(IDuplicateChecker checker)
        {
            //Arrange
            var nums = new[] { 2, 3, 4, 1, 6 };

            //Act
            var result = checker.ContainsDuplicate(nums);

            //Assert
            Assert.False(result);
        }
    }
}