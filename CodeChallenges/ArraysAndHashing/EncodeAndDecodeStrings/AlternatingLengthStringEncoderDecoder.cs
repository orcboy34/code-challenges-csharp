namespace CodeChallenges.ArraysAndHashing.EncodeAndDecodeStrings
{
    /// <summary>
    /// I wrote this after reading the second hint on the NeetCode question.
    /// It's main issue is the memory use during decoding.
    /// </summary>
    internal class AlternatingLengthStringEncoderDecoder : IStringEncoderDecoder
    {
        public string Encode(IList<string> values)
        {
            var result = string.Empty;
            foreach (var value in values)
            {
                result += $"{value.Length}|{value}";
            }
            return result;
        }

        public List<string> Decode(string value)
        {
            var result = new List<string>();
            while (value.Length > 0)
            {
                var strLength = value.Split('|', 2);
                if (int.TryParse(strLength[0], out var length))
                {
                    result.Add(strLength[1][..length]);
                    value = strLength[1][length..];
                }
                else
                {
                    throw new ArgumentException("Input string is incorrectly formatted");
                }
            }
            return result;
        }
    }
}
