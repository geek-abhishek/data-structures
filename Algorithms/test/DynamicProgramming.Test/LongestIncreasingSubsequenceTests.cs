namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class LongestIncreasingSubsequenceTests
    {
        [Theory]
        [InlineData(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }, 4)]
        [InlineData(new int[] { 3, 3, 3, 3 }, 1)]
        [InlineData(new int[] { 0, 1, 0, 3, 2, 3 }, 4)]
        public void LengthOfLIS_ShouldReturn_LengthOfLongestIncreasingSubsequence(
            int[] nums,
            int expectedResult)
        {
            // Arrange
            var increasingSubsequence = new LongestIncreasingSubsequence();

            // Act
            var result = increasingSubsequence.LengthOfLIS(nums);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
