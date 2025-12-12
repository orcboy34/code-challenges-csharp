using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.ArraysAndHashing.AnagramCheckers
{
    public class BuildupTeardownAnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            var charCount = new Dictionary<char, int>();
            // Buildup phase
            foreach (var charA in a)
            {
                charCount[charA] = charCount.GetValueOrDefault(charA, 0) + 1;
            }
            // Teardown phase
            foreach (var charB in b)
            {
                if (!charCount.ContainsKey(charB))
                {
                    return false;
                }
                charCount[charB]--;
            }
            return true;
        }
    }
}
