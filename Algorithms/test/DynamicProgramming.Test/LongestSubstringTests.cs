namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class LongestSubstringTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("pwwkew", 3)]
        [InlineData("dvdf", 3)]
        [InlineData("xxzqi", 4)]
        [InlineData("anviaj", 5)]
        [InlineData("", 0)]
        public void LengthOfLongestSubstring_ShouldReturn_LengthOfLongestNonRepeatedSubstring(
            string s,
            int expectedMaximumLength)
        {
            // Arrange
            var longestSubstring = new LongestSubstring();

            // Act
            var maximumLength = longestSubstring.LengthOfLongestSubstring(s);

            // Assert
            maximumLength.Should().Be(expectedMaximumLength);
        }
    }
}
