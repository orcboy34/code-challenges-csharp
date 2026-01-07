using CodeChallenges.ArraysAndHashing.EncodeAndDecodeStrings;

namespace CodeChallenges.Tests.ArraysAndHashing
{
    /// <summary>
    /// These tests feel bad because they don't test Encode and Decode separately.
    /// The code challenge doesn't have an opinion on what the output of Encode is, so the output can vary
    /// wildly between implementations.
    /// </summary>
    public class StringEncoderDecoderTests
    {
        public static IEnumerable<object[]> EncoderDecoders =>
        [
            [new BruteForceStringEncoderDecoder()],
            [new AlternatingLengthStringEncoderDecoder()],
            [new SeparatedStringEncoderDecoder()]
        ];

        [Theory]
        [MemberData(nameof(EncoderDecoders))]
        public void EncodeDecode_WithEmptyString_ReturnsEncodedString(IStringEncoderDecoder stringEncoderDecoder)
        {
            // Arrange
            List<string> input = [""];

            // Act
            var output = stringEncoderDecoder.Decode(stringEncoderDecoder.Encode(input));

            // Assert
            Assert.Equal(input, output);
        }

        [Theory]
        [MemberData(nameof(EncoderDecoders))]
        public void EncodeDecode_WithTwoStrings_ReturnsEncodedString(IStringEncoderDecoder stringEncoderDecoder)
        {
            // Arrange
            List<string> input = ["Hello", "World"];

            // Act
            var output =  stringEncoderDecoder.Decode(stringEncoderDecoder.Encode(input));

            // Assert
            Assert.Equal(input, output);
        }
    }
}
