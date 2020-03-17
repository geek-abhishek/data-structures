namespace DataStructures.Test
{
    using FluentAssertions;
    using Xunit;

    public class MedianCalculatorTests
    {
        [Theory]
        [InlineData(new int[] { }, new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 3, 4 }, new int[] { 2 }, 2.5)]
        public void GetMedianOfSortedArrays_ShouldReturn_MedianOfTwoSortedArrays(
            int[] nums1,
            int[] nums2,
            double expectedMedian)
        {
            // Arrange
            var medianCalculator = new MedianCalculator();

            // Act
            var median = medianCalculator.GetMedianOfSortedArrays(nums1, nums2);

            // Assert
            median.Should().Be(expectedMedian);
        }
    }
}
