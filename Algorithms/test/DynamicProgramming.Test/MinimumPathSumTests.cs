namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class MinimumPathSumTests
    {
        [Theory]
        [InlineData(6, new int[] { 1, 2, 5 }, new int[] { 3, 2, 1 })]
        [InlineData(7, new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 })]
        public void GetMinimumSum_ShouldReturn_MinimumPathSum(int expectedSum, params int[][] grid)
        {
            // Arrange
            var minimumPath = new MinimumPathSum();

            // Act
            var minimumPathSum = minimumPath.GetMinimumSum(grid);

            // Assert
            minimumPathSum.Should().Be(expectedSum);
        }
    }
}
