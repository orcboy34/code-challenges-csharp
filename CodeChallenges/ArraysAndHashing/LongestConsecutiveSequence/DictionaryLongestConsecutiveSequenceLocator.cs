namespace CodeChallenges.ArraysAndHashing.LongestConsecutiveSequence
{
    internal class DictionaryLongestConsecutiveSequenceLocator : ILongestConsecutiveSequenceLocator
    {
        public int Locate(int[] numbers)
        {
            var dictionary = new Dictionary<int, int>();
            var longestSequence = 0;

            foreach ( var number in numbers )
            {
                if (dictionary.ContainsKey(number))
                    continue; // Number has already been handled, skip it

                // Get the sequence lengths from before and after this one, if they exist.
                var previousSequenceLength = dictionary.TryGetValue(number - 1, out var prior) ? prior : 0;
                var nextSequenceLength = dictionary.TryGetValue(number + 1, out var next) ? next : 0;

                // Update the current number
                dictionary[number] = previousSequenceLength + nextSequenceLength + 1;

                // Update the sequence lengths at either end of the sequence
                if (dictionary.ContainsKey(number - previousSequenceLength))
                    dictionary[number - previousSequenceLength] = dictionary[number];
                if (dictionary.ContainsKey(number + nextSequenceLength))
                    dictionary[number + nextSequenceLength] = dictionary[number];

                longestSequence = Math.Max(longestSequence, dictionary[number]);
            }

            return longestSequence;
        }
    }
}
