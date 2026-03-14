namespace CodeChallenges.ArraysAndHashing.ValidSudoku
{
    internal class HashSetSudokuChecker : IValidSudokuChecker
    {
        public bool Check(char[][] board)
        {
            if (board.Length != 9)
                return false;

            var columns = new HashSet<char>[9];
            var rows = new HashSet<char>[9];
            var blocks = new HashSet<char>[9];

            for (int i = 0; i < 9; i++)
            {
                columns[i] = [];
                rows[i] = [];
                blocks[i] = [];
            }

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].Length != 9) return false;

                for (int j = 0; j < board[i].Length; j++)
                {
                    var val = board[i][j];
                    if (val == '.')
                        continue; // Ignore empty cells

                    if (columns[j].Contains(val))
                        return false;

                    if (rows[i].Contains(val))
                        return false;

                    var block = (i / 3) * 3 + (j / 3);
                    if (blocks[block].Contains(val))
                        return false;

                    rows[i].Add(val);
                    columns[j].Add(val);
                    blocks[block].Add(val);
                }
            }

            return true;
        }
    }
}
