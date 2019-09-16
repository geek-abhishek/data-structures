namespace DynamicProgramming
{
    public class MaximumSubarray
    {
        public int GetMaximumSubarray(int[] numbers)
        {
            var maximumCumulativeSum = numbers[0];
            var cumulativeSum = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    maximumCumulativeSum = 0;
                    cumulativeSum = 0;
                    break;
                }

                if (maximumCumulativeSum < numbers[i])
                {
                    maximumCumulativeSum = numbers[i];
                }
            }

            if (maximumCumulativeSum < 0)
            {
                return maximumCumulativeSum;
            }

            for (var i = 0; i < numbers.Length; i++)
            {
                cumulativeSum = cumulativeSum + numbers[i];

                if (cumulativeSum < 0)
                {
                    cumulativeSum = 0;
                }

                if (maximumCumulativeSum < cumulativeSum)
                {
                    maximumCumulativeSum = cumulativeSum;
                }
            }

            return maximumCumulativeSum;
        }
    }
}
