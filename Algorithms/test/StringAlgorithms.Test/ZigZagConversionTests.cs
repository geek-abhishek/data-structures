namespace StringAlgorithms.Test
{
    using Xunit;
    using FluentAssertions;

    public class ZigZagConversionTests
    {
        [Theory]
        [InlineData("AB", 1, "AB")]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        public void Convert_ShouldConvert_StringToZigZag(
            string input,
            int numberOfRows,
            string expectedOutput)
        {
            // Arrange
            var converter = new ZigZagConversion();

            // Act
            var output = converter.Convert(input, numberOfRows);

            // Assert
            output.Should().Be(expectedOutput);
        }
    }
}
