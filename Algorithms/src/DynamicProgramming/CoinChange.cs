namespace DynamicProgramming
{
    using System;

    public class CoinChange
    {
        public int GetMinimum(int[] coins, int amount)
        {
            if (amount <= 0)
            {
                return 0;
            }

            Array.Sort(coins);

            var minimumCombinations = new int[amount + 1];
            minimumCombinations[0] = 0;

            for (int i = 1; i < minimumCombinations.Length; i++)
            {
                minimumCombinations[i] = amount + 1;
            }

            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] > i)
                    {
                        break;
                    }

                    minimumCombinations[i] = Math.Min(
                        minimumCombinations[i],
                        1 + minimumCombinations[i - coins[j]]);
                }
            }

            return minimumCombinations[amount] > amount
                ? -1
                : minimumCombinations[amount];
        }
    }
}
