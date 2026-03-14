namespace CodeChallenges.ArraysAndHashing.ValidSudoku
{
    internal class BitMaskSudokuChecker : IValidSudokuChecker
    {
        public bool Check(char[][] board)
        {
            if (board.Length != 9)
                return false;

            var columns = new int[9];
            var rows = new int[9];
            var blocks = new int[9];

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].Length != 9) return false;

                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                        continue; // Ignore empty cells

                    var val = board[i][j] - '1'; // Turn the char into an int we can use.

                    // Check each collection.
                    // x & y returns a new int where each bit is only set to 1 if both x and y have a 1 in that position.
                    // ex: 0b0110 & 0b0101 = 0b0100
                    // This means if the comparison returns a non-zero value the flag for the current number is already set.
                    if ((columns[j] & (1 << val)) > 0)
                        return false;

                    if ((rows[i] & (1 << val)) > 0)
                        return false;

                    var block = (i / 3) * 3 + (j / 3);
                    if ((blocks[block] & (1 << val)) > 0)
                        return false;

                    // Set the bit of the value in our collections.
                    rows[i] |= (1 << val);
                    columns[j] |= (1 << val);
                    blocks[block] |= (1 << val);
                }
            }

            return true;
        }
    }
}
