namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class StockTraderTests
    {
        [Theory]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 8, 6, 4, 2, 1 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        public void GetMaximumProfitForSingleTransaction_ShouldReturn_MaximumProfit_ForTradedStocks(int[] prices, int expectedProfit)
        {
            // Arrange
            var stockTrader = new StockTrader();

            // Act
            var profit = stockTrader.GetMaximumProfitForSingleTransaction(prices);

            // Assert
            profit.Should().Be(expectedProfit);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 8, 6, 4, 2, 1 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        public void GetMaximumProfitForMultipleTransactions_ShouldReturn_MaximumProfit_ForTradedStocks(int[] prices, int expectedProfit)
        {
            // Arrange
            var stockTrader = new StockTrader();

            // Act
            var profit = stockTrader.GetMaximumProfitForMultipleTransactions(prices);

            // Assert
            profit.Should().Be(expectedProfit);
        }
    }
}
