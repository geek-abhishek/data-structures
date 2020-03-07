namespace DynamicProgramming
{
    using System.Linq;

    public class MaximumProductSubarray
    {
        public int GetMaximumProduct(int[] nums)
        {
            if (nums == null || nums.Any() == false)
            {
                return 0;
            }

            if (nums.Length.Equals(1))
            {
                return nums[0];
            }

            var previousMinProduct = nums[0];
            var previousMaxProduct = nums[0];
            var maximumProduct = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                var currentMinProduct = GetMinimum(
                    previousMinProduct * nums[i],
                    previousMaxProduct * nums[i],
                    nums[i]);

                var currentMaxProduct = GetMaximum(
                    previousMinProduct * nums[i],
                    previousMaxProduct * nums[i],
                    nums[i]);

                maximumProduct = GetMaximum(
                    maximumProduct, currentMaxProduct);

                previousMinProduct = currentMinProduct;
                previousMaxProduct = currentMaxProduct;
            }

            return maximumProduct;
        }

        private int GetMinimum(params int[] numbers)
        {
            var minimum = numbers[0];

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }

            return minimum;
        }

        private int GetMaximum(params int[] numbers)
        {
            var maximum = numbers[0];

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
            }

            return maximum;
        }
    }
}
