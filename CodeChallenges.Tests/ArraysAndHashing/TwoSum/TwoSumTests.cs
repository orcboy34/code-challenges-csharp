using CodeChallenges.ArraysAndHashing.TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Tests.ArraysAndHashing.TwoSum
{
    public abstract class TwoSumTests
    {
        protected abstract ITwoSumChecker CreateChecker();

        [Fact]
        public void TwoSum_WithDistinctElements_ReturnsCorrectIndices()
        {
            // Arrange
            var checker = CreateChecker();
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            // Act
            var result = checker.TwoSum(nums, target);
            // Assert
            Assert.Equal([0, 1], result);
        }

        [Fact]
        public void TwoSum_WithDuplicateElements_ReturnsCorrectIndices()
        {
            // Arrange
            var checker = CreateChecker();
            var nums = new int[] { 3, 2, 5, 3 };
            var target = 6;
            // Act
            var result = checker.TwoSum(nums, target);
            // Assert
            Assert.Equal([0, 3], result);
        }

        [Fact]
        public void TwoSum_WithNegativeNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            var checker = CreateChecker();
            var nums = new int[] { -3, 4, 3, 9 };
            var target = 0;
            // Act
            var result = checker.TwoSum(nums, target);
            // Assert
            Assert.Equal([0, 2], result);
        }
    }
}
