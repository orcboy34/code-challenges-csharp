namespace CodeChallenges.ArraysAndHashing.DuplicateCheckers
{
    public class HashSetLengthDuplicateChecker : IDuplicateChecker
    {
        public bool ContainsDuplicate(int[] nums) =>
            new HashSet<int>(nums).Count < nums.Length;
    }
}
