namespace DynamicProgramming
{
    using System;
    using System.Collections.Generic;

    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 1;
            }

            if (nums.Length == 2)
            {
                return nums[0] < nums[1] ? 2 : 1;
            }

            var lengths = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                lengths.Add(1);
            }

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == i)
                    {
                        break;
                    }

                    if (nums[j] < nums[i])
                    {
                        lengths[i] = Math.Max(lengths[i], lengths[j] + 1);
                    }
                }
            }

            var maxLength = lengths[0];
            for(int i = 1; i < lengths.Count; i++)
            {
                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                }
            }

            return maxLength;
        }
    }
}
