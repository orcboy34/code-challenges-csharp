namespace CodeChallenges.ArraysAndHashing.TwoSum
{
    internal class SortingTwoSumChecker : ITwoSumChecker
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var sortedNums = nums
                .Select((value, index) => new { Value = value, Index = index })
                .OrderBy(x => x.Value)
                .ToList();

            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int sum = sortedNums[left].Value + sortedNums[right].Value;
                if (sum == target)
                {
                    return [sortedNums[left].Index, sortedNums[right].Index];
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return [];
        }
    }
}
