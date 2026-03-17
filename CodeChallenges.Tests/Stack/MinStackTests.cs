using CodeChallenges.Stack.MinStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.Tests.Stack
{
    public class MinStackTests
    {
        public static IEnumerable<object[]> MinStacks =>
        [
            [new MinStack()]
        ];

        [Theory]
        [MemberData(nameof(MinStacks))]
        public void MinStack_WithUniqueElements_ReturnsCorrectTop(IMinStack minStack)
        {
            //Arrange
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);

            //Act
            var result = minStack.Top();

            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [MemberData(nameof(MinStacks))]
        public void MinStack_WithDuplicateElements_ReturnsCorrectTop(IMinStack minStack)
        {
            //Arrange
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(1);
            minStack.Push(0);

            //Act
            var result = minStack.Top();

            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [MemberData(nameof(MinStacks))]
        public void MinStack_WithPoppedElement_ReturnsCorrectTop(IMinStack minStack)
        {
            //Arrange
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);
            minStack.Pop();

            //Act
            var result = minStack.Top();

            //Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [MemberData(nameof(MinStacks))]
        public void MinStack_WithUniqueElements_ReturnsCorrectMin(IMinStack minStack)
        {
            //Arrange
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);

            //Act
            var result = minStack.GetMin();

            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [MemberData(nameof(MinStacks))]
        public void MinStack_WithPoppedElement_ReturnsCorrectMin(IMinStack minStack)
        {
            //Arrange
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);
            minStack.Pop();

            //Act
            var result = minStack.GetMin();

            //Assert
            Assert.Equal(1, result);
        }

        [Theory]
        [MemberData(nameof(MinStacks))]
        public void MinStack_WithDuplicatePoppedElement_ReturnsCorrectMin(IMinStack minStack)
        {
            //Arrange
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);
            minStack.Push(0);
            minStack.Pop();

            //Act
            var result = minStack.GetMin();

            //Assert
            Assert.Equal(0, result);
        }
    }
}
