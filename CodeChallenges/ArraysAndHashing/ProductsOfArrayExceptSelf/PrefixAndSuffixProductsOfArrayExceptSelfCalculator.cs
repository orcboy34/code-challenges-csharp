namespace CodeChallenges.ArraysAndHashing.ProductsOfArrayExceptSelf
{
    internal class PrefixAndSuffixProductsOfArrayExceptSelfCalculator : IProductsOfArrayExceptSelfCalculator
    {
        public int[] Calculate(int[] integers)
        {
            var length = integers.Length;
            var result = new int[length];

            // These arrays will contain the product of all elements before and after the index respectively.
            var prefix = new int[length];
            var suffix = new int[length];

            prefix[0] = 1; // Nothing to the left of 0
            suffix[length - 1] = 1; // Nothing to the right of the last element

            // Build the prefix array.
            for (var i = 1; i < length; i++)
            {
                prefix[i] = integers[i - 1] * prefix[i - 1];
            }

            // Build the suffix array.
            for (var i = length - 2; i >= 0; i--)
            {
                suffix[i] = integers[i + 1] * suffix[i + 1];
            }

            // Now the result is just prefix * suffix
            for (var i = 0; i < length; i++)
            {
                result[i] = prefix[i] * suffix[i];
            }

            return result;
        }
    }
}
