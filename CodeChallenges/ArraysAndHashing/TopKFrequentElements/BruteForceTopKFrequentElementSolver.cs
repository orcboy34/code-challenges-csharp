namespace CodeChallenges.ArraysAndHashing.TopKFrequentElements
{
    internal class BruteForceTopKFrequentElementSolver : ITopKFrequentElementSolver
    {
        public IEnumerable<int> TopKFrequentElements(int[] nums, int k)
        {
            var valueFrequencies = new Dictionary<int, int>();
            foreach (var i in nums)
            {
                if (valueFrequencies.ContainsKey(i))
                    valueFrequencies[i]++;
                else
                    valueFrequencies[i] = 1;
            }
            var sorted = valueFrequencies.OrderByDescending(p => p.Value);
            var result = new List<int>(k);
            foreach (var i in sorted)
            {
                result.Add(i.Key);
                if (result.Count == k)
                    break;
            }
            return result;
        }
    }
}
