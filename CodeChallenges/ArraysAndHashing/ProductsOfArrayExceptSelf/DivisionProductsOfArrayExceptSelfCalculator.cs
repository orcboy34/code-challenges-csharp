namespace CodeChallenges.ArraysAndHashing.ProductsOfArrayExceptSelf
{
    internal class DivisionProductsOfArrayExceptSelfCalculator : IProductsOfArrayExceptSelfCalculator
    {
        public int[] Calculate(int[] integers)
        {
            var product = 1;
            var zeroCount = 0;
            var zeroPosition = 0;

            for (var i = 0; i < integers.Length; i++)
            {
                if (integers[i] == 0)
                {
                    zeroCount++;
                    zeroPosition = i;
                }
                else
                {
                    product *= integers[i];
                }
            }

            var result = new int[integers.Length];
            if (zeroCount > 0)
            {
                // If there is a single zero, only the zero's product will have a value, all others will be zero.
                // If there is more than one zero, all product calculations will contain at least one zero, so all products will be zero.
                if (zeroCount == 1)
                {
                    result[zeroPosition] = product;
                }
                return result;
            }

            for (var i = 0; i < integers.Length; i++)
            {
                result[i] = product / integers[i];
            }

            return result;
        }
    }
}
