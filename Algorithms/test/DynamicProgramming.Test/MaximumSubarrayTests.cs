namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class MaximumSubarrayTests
    {
        [Theory]
        [InlineData(new int[] { -1 }, -1)]
        [InlineData(new int[] { -1, -2 }, -1)]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [InlineData(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 7)]
        public void GetMaximumSubarray_ShouldReturn_MaximumSubarrayInArray(
            int[] numbers, int expectedSumOfMaximumSubarray)
        {
            // Arrange
            var maximumSubArray = new MaximumSubarray();

            // Act
            var sumOfMaximumSubarray = maximumSubArray.GetMaximumSubarray(numbers);

            // Assert
            sumOfMaximumSubarray.Should().Be(expectedSumOfMaximumSubarray);
        }
    }
}
