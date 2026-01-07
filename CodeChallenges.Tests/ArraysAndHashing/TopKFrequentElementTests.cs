using CodeChallenges.ArraysAndHashing.TopKFrequentElements;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class TopKFrequentElementTests
    {
        public static IEnumerable<object[]> Solvers => [
            [new BruteForceTopKFrequentElementSolver()],
            [new MinHeapTopKFrequentElementSolver()]
        ];

        [Theory]
        [MemberData(nameof(Solvers))]
        public void TopKFrequentElements_WithOneValue_ReturnsMostFrequent(ITopKFrequentElementSolver solver)
        {
            //Arrange
            int[] nums = [7, 7];
            var k = 1;

            //Act
            var result = solver.TopKFrequentElements(nums, k);

            //Assert
            Assert.Equal([7], result);
        }

        [Theory]
        [MemberData(nameof(Solvers))]
        public void TopKFrequentElements_WithThreeValues_ReturnsTwoMostFrequent(ITopKFrequentElementSolver solver)
        {
            //Arrange
            int[] nums = [1, 2, 2, 3, 3, 3];
            var k = 2;

            //Act
            var result = solver.TopKFrequentElements(nums, k);

            //Assert
            Assert.Equal([2, 3], result.OrderBy(x => x));
        }

        [Theory]
        [MemberData(nameof(Solvers))]
        public void TopKFrequentElements_WithFiveValues_ReturnsThreeMostFrequent(ITopKFrequentElementSolver solver)
        {
            //Arrange
            int[] nums = [1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 5];
            var k = 3;

            //Act
            var result = solver.TopKFrequentElements(nums, k);

            //Assert
            Assert.Equal([1, 2, 3], result.OrderBy(x => x));
        }
    }
}
