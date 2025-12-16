using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.ArraysAndHashing.TwoSum
{
    internal class TwoPassHashMapTwoSumChecker : ITwoSumChecker
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var indices = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                indices[nums[i]] = i;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (indices.TryGetValue(complement, out int value) && value != i)
                {
                    return [i, value];
                }
            }

            return [];
        }
    }
}
