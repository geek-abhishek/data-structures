namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class MaximumProductSubarrayTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)]
        [InlineData(new int[] { -2, 0, -1 }, 0)]
        [InlineData(new int[] { -4, -3 }, 12)]
        [InlineData(new int[] { 2, -4, 3, -2 }, 48)]
        [InlineData(new int[] { 2, -5, -2, -4, 3 }, 24)]
        public void GetMaximumProduct_ShouldReturn_MaximumProductInSubArray(int[] nums, int expectedProduct)
        {
            // Arrange
            var maximumProductCalculator = new MaximumProductSubarray();

            // Act
            var product = maximumProductCalculator.GetMaximumProduct(nums);

            // Assert
            product.Should().Be(expectedProduct);
        }
    }
}
