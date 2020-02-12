namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using System.Linq;
    using Xunit;

    public class WordBreakTests
    {
        [Theory]
        [InlineData("a", new string[] { "b" })]
        [InlineData("catsandog", new string[] { "cats", "dog", "sand", "and", "cat" })]
        public void CanBeSegmented_ShouldReturnFalse_WhenWordsCannotBeSegmented(
            string s,
            string[] wordDict)
        {
            // Arrange
            var wordBreak = new WordBreak();

            // Act
            var result = wordBreak.CanBeSegmented(s, wordDict.ToList());

            // Assert
            result.Should().Be(false);
        }

        [Theory]
        [InlineData("a", new string[] { "a" })]
        [InlineData("abhishek", new string[] { "abhi", "shek" })]
        [InlineData("applepenapple", new string[] { "apple", "pen" })]
        [InlineData("cars", new string[] { "car", "ca", "rs" })]
        [InlineData("abcd", new string[] {"a", "abc", "b", "cd"})]
        public void CanBeSegmented_ShouldReturnTrue_WhenWordsCanBeSegmented(
            string s,
            string[] wordDict)
        {
            // Arrange
            var wordBreak = new WordBreak();

            // Act
            var result = wordBreak.CanBeSegmented(s, wordDict.ToList());

            // Assert
            result.Should().Be(true);
        }
    }
}
