namespace CodeChallenges.ArraysAndHashing.EncodeAndDecodeStrings
{
    /// <summary>
    ///   λ is a non-ASCII charater, so it won't be in any of the input strings.
    ///   This allows us to join and split the string safely, but only because of the ASCII contraint.
    ///   A better solution would allow for any character set.
    /// </summary>
    internal class BruteForceStringEncoderDecoder : IStringEncoderDecoder
    {

        public string Encode(IList<string> values)
        {
            if ((values?.Count ?? 0) == 0)
                return string.Empty;

            var result = string.Join('λ', values);

            return string.IsNullOrEmpty(result) ? "λ" : string.Join('λ', values);
        }

        public List<string> Decode(string value)
        {
            return string.IsNullOrEmpty(value) ? [] : value == "λ" ? [""] : [.. value.Split('λ')];
        }
    }
}
