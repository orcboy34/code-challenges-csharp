namespace CodeChallenges.ArraysAndHashing.DuplicateCheckers
{
    public class HashSetDuplicateChecker : IDuplicateChecker
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var seenNumbers = new HashSet<int>();
            foreach (var num in nums)
            {
                if (seenNumbers.Contains(num))
                {
                    return true;
                }
                seenNumbers.Add(num);
            }
            return false;
        }
    }
}
