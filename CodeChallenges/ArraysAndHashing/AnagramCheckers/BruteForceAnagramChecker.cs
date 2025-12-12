namespace CodeChallenges.ArraysAndHashing.AnagramCheckers
{
    public class BruteForceAnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var arrayA = a.ToCharArray();
            var arrayB = b.ToCharArray();

            Array.Sort(arrayA);
            Array.Sort(arrayB);

            var sortedA = new string(arrayA);
            var sortedB = new string(arrayB);

            return sortedA == sortedB;
        }
    }
}
