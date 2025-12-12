using CodeChallenges.ArraysAndHashing.AnagramCheckers;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class AnagramCheckerTests
    {
        public static IEnumerable<object[]> Checkers =>
        [
            [new BruteForceAnagramChecker()],
            [new ArrayAnagramChecker()],
            [new DictionaryAnagramChecker()],
            [new BuildupTeardownAnagramChecker()]
        ];

        [Theory]
        [MemberData(nameof(Checkers))]
        public void IsAnagram_WithAnagramStrings_ReturnsTrue(IAnagramChecker checker)
        {
            //Arrange
            var a = "listen";
            var b = "silent";

            //Act
            var result = checker.IsAnagram(a, b);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(Checkers))]
        public void IsAnagram_WithNonAnagramStrings_ReturnsFalse(IAnagramChecker checker)
        {
            //Arrange
            var a = "hello";
            var b = "world";

            //Act
            var result = checker.IsAnagram(a, b);

            //Assert
            Assert.False(result);
        }
    }
}
