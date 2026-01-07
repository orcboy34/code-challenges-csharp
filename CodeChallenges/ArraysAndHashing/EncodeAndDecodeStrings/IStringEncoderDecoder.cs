namespace CodeChallenges.ArraysAndHashing.EncodeAndDecodeStrings
{
    public interface IStringEncoderDecoder
    {
        string Encode(IList<string> values);
        List<string> Decode(string value);
    }
}
