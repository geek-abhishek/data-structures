namespace DynamicProgramming
{
    using System;
    using System.Collections.Generic;

    public class DiceRollWithTargetSum
    {
        private readonly int modulus = (int)Math.Pow(10, 9) + 7;
        private readonly Dictionary<string, int> results = new Dictionary<string, int>();

        public int NumRollsToTarget(int d, int f, int target)
        {
            if (d == 0 && target == 0)
            {
                return 1;
            }

            if (d == 0)
            {
                return 0;
            }

            var key = $"{target}|{d}";
            if (results.ContainsKey(key))
            {
                return results[key];
            }

            int numberOfWays = 0;
            for (int i = 1; i <= f; i++)
            {
                numberOfWays =
                    (numberOfWays + this.NumRollsToTarget(d - 1, f, target - i)) % modulus;
            }

            results[key] = numberOfWays;
            return numberOfWays;
        }
    }
}
