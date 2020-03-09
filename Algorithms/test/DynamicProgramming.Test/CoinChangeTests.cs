namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class CoinChangeTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 5 }, 11, 3)]
        [InlineData(new int[] { 3, 5 }, 2, -1)]
        public void GetMinimum_ShouldReturn_MinimumCombinations_ForYieldingAmount(
            int[] coins,
            int amount,
            int expectedCombinations)
        {
            // Arrange
            var coinChange = new CoinChange();

            // Act
            var combinations = coinChange.GetMinimum(coins, amount);

            // Assert
            combinations.Should().Be(expectedCombinations);
        }
    }
}
