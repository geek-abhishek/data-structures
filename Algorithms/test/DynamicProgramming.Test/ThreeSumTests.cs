namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class ThreeSumTests
    {
        [Theory]
        //[InlineData(new int[] { 0, 0, 0 }, 1)]
        //[InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { -1, 0, 1, 2, -1, -4 }, 2)]
        public void GetThreeSum_ShouldReturn_ThreeSum(
            int[] nums,
            int expectedThreeSumCount)
        {
            // Arrange
            var threeSum = new ThreeSum();

            // Act
            var result = threeSum.GetThreeSum(nums);

            // Assert
            result.Count.Should().Be(expectedThreeSumCount);
        }
    }
}
