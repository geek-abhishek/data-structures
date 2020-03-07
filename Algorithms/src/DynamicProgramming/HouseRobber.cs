namespace DynamicProgramming
{
    using System;
    using System.Linq;

    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Any() == false)
            {
                return 0;
            }

            if (nums.Length.Equals(1))
            {
                return nums[0];
            }

            if (nums.Length.Equals(2))
            {
                return Math.Max(nums[0], nums[1]);
            }

            var maxSums = new int[3];
            maxSums[0] = nums[0];
            maxSums[1] = Math.Max(nums[0], nums[1]);

            for (var i = 2; i < nums.Length; i++)
            {
                maxSums[2] = Math.Max(nums[i] + maxSums[0], maxSums[1]);
                maxSums[0] = maxSums[1];
                maxSums[1] = maxSums[2];
            }

            return maxSums[2];
        }
    }
}
