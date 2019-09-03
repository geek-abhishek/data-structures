namespace StringAlgorithms.Test
{
    using FluentAssertions;
    using Xunit;

    public class RabinKarpMatcherTests
    {
        [Theory]
        [InlineData("mississippi", "iss", 2)]
        [InlineData("mississippi", "sip", 1)]
        [InlineData("mississippi", "isi", 0)]
        [InlineData("mississippi", null, 0)]
        [InlineData("", "ppi", 0)]
        [InlineData(null, null, 0)]
        public void GetMatchingIndexes_InRabinKarpMatcher_ShouldReturn_MatchingPatternIndexes(
            string text,
            string pattern,
            int matchingIndexCount)
        {
            // Arrange
            IStringMatcher stringMatcher = new RabinKarpMatcher();

            // Act
            var matchingIndexes = stringMatcher.GetMatchingIndexes(text, pattern);

            // Assert
            matchingIndexes.Count.Should().Be(matchingIndexCount);
        }
    }
}
