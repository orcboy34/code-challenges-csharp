namespace CodeChallenges.ArraysAndHashing.AnagramCheckers
{
    public class DictionaryAnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var charCountA = new Dictionary<char, int>();
            var charCountB = new Dictionary<char, int>();

            for (int i = 0; i < a.Length; i++)
            {
                charCountA[a[i]] = charCountA.GetValueOrDefault(a[i], 0) + 1;
                charCountB[b[i]] = charCountB.GetValueOrDefault(b[i], 0) + 1;
            }
            return charCountA.Count == charCountB.Count && !charCountA.Except(charCountB).Any();
        }
    }
}
