namespace DynamicProgramming
{
    using System;

    public class StockTrader
    {
        public int GetMaximumProfit(int[] prices)
        {
            var maximumProfitInNegative = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] - prices[j] < maximumProfitInNegative)
                    {
                        maximumProfitInNegative = prices[i] - prices[j];
                    }
                }
            }

            return Math.Abs(maximumProfitInNegative);
        }
    }
}
