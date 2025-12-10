namespace CodeChallenges.ArraysAndHashing.DuplicateCheckers
{
    public class SortingDuplicateChecker : IDuplicateChecker
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
