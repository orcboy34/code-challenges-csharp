using CodeChallenges.ArraysAndHashing.LongestConsecutiveSequence;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class LongestConsecutiveSequenceLocatorTests
    {
        public static IEnumerable<object[]> Locaters => [
            [new SortedSetLongestConsecutiveSequenceLocator()],
            [new DictionaryLongestConsecutiveSequenceLocator()]
        ];

        [Theory]
        [MemberData(nameof(Locaters))]
        public void LongestConsecutiveSequenceLocator_WithFiveSequence_ReturnsFive(ILongestConsecutiveSequenceLocator locator)
        {
            //Arrange
            int[] elements = [2, 20, 4, 10, 6, 3, 4, 5];

            //Act
            var result = locator.Locate(elements);

            Assert.Equal(5, result);
        }

        [Theory]
        [MemberData(nameof(Locaters))]
        public void LongestConsecutiveSequenceLocator_WithSevenSequence_ReturnsSeven(ILongestConsecutiveSequenceLocator locator)
        {
            //Arrange
            int[] elements = [0, 3, 2, 5, 4, 6, 1, 1];

            //Act
            var result = locator.Locate(elements);

            Assert.Equal(7, result);
        }
    }
}
