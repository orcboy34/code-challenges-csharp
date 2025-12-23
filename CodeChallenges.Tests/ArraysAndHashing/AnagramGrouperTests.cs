using CodeChallenges.ArraysAndHashing.GroupAnagrams;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class AnagramGrouperTests
    {
        public static IEnumerable<object[]> Groupers => [
            [new SortingAnagramGrouper()],
            [new FrequencyAnagramGrouper()]
        ];

        [Theory]
        [MemberData(nameof(Groupers))]
        public void GroupAnagrams_WithNoAnagrams_ReturnsCorrectGroups(IAnagramGrouper anagramGrouper)
        {
            //Arrange
            string[] strs = ["cats", "stamp", "shove"];

            //Act
            var result = anagramGrouper.GroupAnagrams(strs);

            //Assert
            Assert.Equal([["cats"], ["stamp"], ["shove"]], result);
        }

        [Theory]
        [MemberData(nameof (Groupers))]
        public void GroupAnagrams_WithAnagrams_ReturnsCorrectGroups(IAnagramGrouper anagramGrouper)
        {
            //Arrange
            string[] strs = ["act", "pots", "tops", "cat", "stop", "hat"];

            //Act
            var result = anagramGrouper.GroupAnagrams(strs);

            //Assert
            Assert.Equal([["act", "cat"], ["pots", "tops", "stop"], ["hat"]], result);
        }
    }
}
