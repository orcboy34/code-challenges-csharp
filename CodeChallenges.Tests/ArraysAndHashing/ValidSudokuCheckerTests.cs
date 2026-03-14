using CodeChallenges.ArraysAndHashing.ValidSudoku;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    public class ValidSudokuCheckerTests
    {
        public static IEnumerable<object[]> Checkers => [
            [new HashSetSudokuChecker()],
            [new BitMaskSudokuChecker() ]
        ];

        [Theory]
        [MemberData(nameof(Checkers))]
        public void ValidSudokuChecker_WithValidBoard_ReturnsTrue(IValidSudokuChecker checker)
        {
            //Arrange
            char[][] board = [
                ['1','2','.','.','3','.','.','.','.'],
                ['4','.','.','5','.','.','.','.','.'],
                ['.','9','8','.','.','.','.','.','3'],
                ['5','.','.','.','6','.','.','.','4'],
                ['.','.','.','8','.','3','.','.','5'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','.','.','.','.','.','2','.','.'],
                ['.','.','.','4','1','9','.','.','8'],
                ['.','.','.','.','8','.','.','7','9']
            ];

            //Act
            var valid = checker.Check(board);

            //Assert
            Assert.True(valid);
        }

        [Theory]
        [MemberData(nameof(Checkers))]
        public void ValidSudokuChecker_WithInvalidBoard_ReturnsFalse(IValidSudokuChecker checker)
        {
            //Arrange
            char[][] board = [
                ['1','2','.','.','3','.','.','.','.'],
                ['4','.','.','5','.','.','.','.','.'],
                ['.','9','1','.','.','.','.','.','3'],
                ['5','.','.','.','6','.','.','.','4'],
                ['.','.','.','8','.','3','.','.','5'],
                ['7','.','.','.','2','.','.','.','6'],
                ['.','.','.','.','.','.','2','.','.'],
                ['.','.','.','4','1','9','.','.','8'],
                ['.','.','.','.','8','.','.','7','9']
            ];

            //Act
            var valid = checker.Check(board);

            //Assert
            Assert.False(valid);
        }
    }
}
