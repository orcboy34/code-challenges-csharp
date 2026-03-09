namespace CodeChallenges.ArraysAndHashing.ProductsOfArrayExceptSelf
{
    internal class BruteForceProductsOfArrayExceptSelfCalculator : IProductsOfArrayExceptSelfCalculator
    {
        public int[] Calculate(int[] integers)
        {
            var result = new int[integers.Length];
            for (var i = 0; i < result.Length; i++)
            {
                var product = 1;
                for (var j = 0; j < integers.Length; j++)
                {
                    if (j != i)
                        product *= integers[j];
                }
                result[i] = product;
            }
            return result;
        }
    }
}
