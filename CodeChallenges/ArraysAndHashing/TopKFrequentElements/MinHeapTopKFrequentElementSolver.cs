namespace CodeChallenges.ArraysAndHashing.TopKFrequentElements
{
    internal class MinHeapTopKFrequentElementSolver : ITopKFrequentElementSolver
    {
        public IEnumerable<int> TopKFrequentElements(int[] nums, int k)
        {
            var counts = new Dictionary<int, int>();
            foreach (var i in nums)
            {
                if (counts.TryGetValue(i, out int value))
                {
                    counts[i] = ++value;
                }
                else
                {
                    counts[i] = 1;
                }
            }

            var heap = new PriorityQueue<int, int>();
            foreach (var entry in counts)
            {
                heap.Enqueue(entry.Key, entry.Value);
                if (heap.Count > k)
                    heap.Dequeue();
            }

            var result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = heap.Dequeue();
            }
            return result;
        }
    }
}
