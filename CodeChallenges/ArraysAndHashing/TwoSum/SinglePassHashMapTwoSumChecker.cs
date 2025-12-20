namespace CodeChallenges.ArraysAndHashing.TwoSum
{
    internal class SinglePassHashMapTwoSumChecker : ITwoSumChecker
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var previousNumbers = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (previousNumbers.TryGetValue(complement, out int value))
                {
                    return [value, i];
                }
                previousNumbers[nums[i]] = i;
            }

            return [];
        }
    }
}
