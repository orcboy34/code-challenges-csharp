namespace CodeChallenges.ArraysAndHashing.AnagramCheckers
{
    public class ArrayAnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            int[] charCounts = new int[26];
            for (int i = 0; i < a.Length; i++)
            {
                charCounts[a[i] - 'a']++;
                charCounts[b[i] - 'a']--;
            }

            foreach (var count in charCounts)
            {
                if (count != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
