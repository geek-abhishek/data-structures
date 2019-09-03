namespace StringAlgorithms.Test
{
    using FluentAssertions;
    using Xunit;

    public class KMPMatcherTests
    {
        [Theory]
        [InlineData("abcdabcdabca", "abcdabca", 1)]
        [InlineData("abdabcabcaby", "abcaby", 1)]
        [InlineData("baabaabaabaabaaa", "aabaabaaa", 1)]
        [InlineData("mississippi", "iss", 2)]
        [InlineData("mississippi", "sip", 1)]
        [InlineData("mississippi", "isi", 0)]
        [InlineData("mississippi", null, 0)]
        [InlineData("", "ppi", 0)]
        [InlineData(null, null, 0)]
        public void GetMatchingIndexes_InKMPMatcher_ShouldReturn_MatchingPatternIndexes(
            string text,
            string pattern,
            int matchingIndexCount)
        {
            // Arrange
            IStringMatcher stringMatcher = new KMPMatcher();

            // Act
            var matchingIndexes = stringMatcher.GetMatchingIndexes(text, pattern);

            // Assert
            matchingIndexes.Count.Should().Be(matchingIndexCount);
        }
    }
}
