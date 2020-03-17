namespace DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class MedianCalculator
    {
        public double GetMedianOfSortedArrays(int[] nums1, int[] nums2)
        {
            int low1 = 0;
            int high1 = nums1.Length - 1;

            int low2 = 0;
            int high2 = nums2.Length - 1;

            List<int> numbers = new List<int>();

            if (nums1.Any() == false && nums2.Any() == false)
            {
                return 0;
            }

            if (nums1.Any() == false)
            {
                numbers.AddRange(nums2);
            }
            else if (nums2.Any() == false)
            {
                numbers.AddRange(nums1);
            }
            else if (nums1[low1] >= nums2[high2])
            {
                numbers.AddRange(nums2);
                numbers.AddRange(nums1);
            }
            else if (nums2[low2] >= nums1[high1])
            {
                numbers.AddRange(nums1);
                numbers.AddRange(nums2);
            }
            else
            {
                int[] small;

                if (nums1.Length < nums2.Length)
                {
                    numbers.AddRange(nums2);
                    small = nums1;
                }
                else
                {
                    numbers.AddRange(nums1);
                    small = nums2;
                }

                foreach (int num in small)
                {
                    int index = GetIndex(numbers, num);
                    Insert(numbers, num, index);
                }
            }

            int medianIndex = numbers.Count / 2;

            if (numbers.Count % 2 != 0)
            {
                return (double)numbers[medianIndex];
            }

            return (double)(numbers[medianIndex] + numbers[medianIndex - 1]) / 2;
        }

        private int GetIndex(List<int> nums, int target)
        {
            int high = nums.Count - 1;
            int low = 0;

            if (target > nums[high])
            {
                return high + 1;
            }

            if (target < nums[low])
            {
                return 0;
            }

            int lastUpdated = 0;


            while (high >= low)
            {
                int mid = (low + high) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target < nums[mid])
                {
                    high = mid - 1;
                    continue;
                }

                if (target > nums[mid])
                {
                    low = mid + 1;
                    lastUpdated = low;
                }
            }

            return lastUpdated;
        }

        private void Insert(List<int> numbers, int newElement, int position)
        {
            numbers.Add(newElement);

            for (int i = numbers.Count - 1; i > position; i--)
            {
                int temp = numbers[i];
                numbers[i] = numbers[i - 1];
                numbers[i - 1] = temp;
            }
        }
    }
}
