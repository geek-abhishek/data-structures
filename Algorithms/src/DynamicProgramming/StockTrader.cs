namespace DynamicProgramming
{
    using System.Collections.Generic;
    using System.Linq;

    public class StockTrader
    {
        public int GetMaximumProfitForSingleTransaction(int[] prices)
        {
            if (prices.Any() == false)
            {
                return 0;
            }

            if (prices.Length.Equals(1))
            {
                return 0;
            }

            var maximumProfit = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > maximumProfit)
                    {
                        maximumProfit = prices[j] - prices[i];
                    }
                }
            }

            return maximumProfit;
        }

        public int GetMaximumProfitForMultipleTransactions(int[] prices)
        {
            if (prices.Any() == false)
            {
                return 0;
            }

            prices = GetReducedPrices(prices);

            if (prices.Length.Equals(1))
            {
                return 0;
            }

            var tabulatedPrices = new int[prices.Length, prices.Length];

            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    tabulatedPrices[i, j] = prices[j] - prices[i] <= 0 ? 0 : prices[j] - prices[i];
                }
            }

            for (var i = prices.Length - 2; i >= 0; i--)
            {
                var previousMaximumProfit = 0;

                for (var j = prices.Length - 1; j > i; j--)
                {
                    var maximumProfit = 0;

                    if (previousMaximumProfit.Equals(0) == false)
                    {
                        maximumProfit = tabulatedPrices[j, j + 1] > previousMaximumProfit
                            ? tabulatedPrices[j, j + 1]
                            : previousMaximumProfit;

                        tabulatedPrices[i, j] += maximumProfit;
                        previousMaximumProfit = maximumProfit;
                        continue;
                    }

                    for (var k = j + 1; k < prices.Length; k++)
                    {
                        if (tabulatedPrices[j, k] > maximumProfit)
                        {
                            maximumProfit = tabulatedPrices[j, k];
                        }
                    }

                    tabulatedPrices[i, j] += maximumProfit;
                    previousMaximumProfit = maximumProfit;
                }
            }

            var maximumRealizedProfit = tabulatedPrices[0, 1];
            for (var i = 2; i < prices.Length; i++)
            {
                if (tabulatedPrices[0, i] > maximumRealizedProfit)
                {
                    maximumRealizedProfit = tabulatedPrices[0, i];
                }
            }

            return maximumRealizedProfit;
        }

        private int[] GetReducedPrices(int[] prices)
        {
            var reducedPrices = new List<int>();
            var isDescending = true;

            for (var i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    isDescending = false;
                }

                if (isDescending == false)
                {
                    reducedPrices.Add(prices[i]);
                }
            }

            reducedPrices.Add(prices[prices.Length - 1]);
            var lastNonZeroIndex = reducedPrices.Count - 1;

            for (int i = reducedPrices.Count - 1; i >= 0; i--)
            {
                if (reducedPrices[i].Equals(0) == false)
                {
                    lastNonZeroIndex = i;
                    break;
                }
            }

            var trimmedPrices = new List<int>();
            for (var i = 0; i <= lastNonZeroIndex; i++)
            {
                trimmedPrices.Add(reducedPrices[i]);
            }

            return trimmedPrices.ToArray();
        }
    }
}
