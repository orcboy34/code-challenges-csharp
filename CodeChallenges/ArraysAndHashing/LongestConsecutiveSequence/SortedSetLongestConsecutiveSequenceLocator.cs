namespace CodeChallenges.ArraysAndHashing.LongestConsecutiveSequence
{
    internal class SortedSetLongestConsecutiveSequenceLocator : ILongestConsecutiveSequenceLocator
    {
        public int Locate(int[] numbers)
        {
            if (numbers.Length < 2)
                return numbers.Length;

            var sorted = new SortedSet<int>(numbers);

            var longestSequence = 0; 
            var currentSequence = 0;
            int? previous = null;

            foreach (var number in sorted)
            {
                if (previous.HasValue && number == previous + 1)
                {
                    // Increase the length of the sequence
                    currentSequence++;
                    previous = number;
                }
                else 
                {
                    // This is the first number in a new sequence
                    currentSequence = 1;
                    previous = number;
                }

                if (currentSequence > longestSequence)
                    longestSequence = currentSequence;
            }

            return longestSequence;
        }
    }
}
