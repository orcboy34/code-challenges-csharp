
namespace CodeChallenges.ArraysAndHashing.EncodeAndDecodeStrings
{
    internal class SeparatedStringEncoderDecoder : IStringEncoderDecoder
    {
        public string Encode(IList<string> values)
        {
            if ((values?.Count ?? 0) == 0)
                return string.Empty;

            var lengths = values.Select(s => s.Length.ToString());
            var result = $"{string.Join(',', lengths)},#";

            foreach (var value in values)
            {
                result += value;
            }

            return result;
        }

        public List<string> Decode(string value)
        {
            if (string.IsNullOrEmpty(value))
                return [];

            List<int> lengths = [];
            List<string> values = [];
            int i = 0;
            // First, build the list of lengths
            while (value[i] != '#')
            {
                string stringLength = string.Empty;
                while (value[i] != ',')
                {
                    stringLength += value[i++];
                }
                lengths.Add(int.Parse(stringLength));
                i++;
            }
            //We've hit the #, now skip over it to the strings.
            i++;
            foreach (var length in lengths)
            {
                values.Add(value.Substring(i, length));
                i += length;
            }

            return values;
        }
    }
}
