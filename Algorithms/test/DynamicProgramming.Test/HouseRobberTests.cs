namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class HouseRobberTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2 }, 4)]
        [InlineData(new int[] {1, 2, 3, 1}, 4)]
        [InlineData(new int[] { 2, 7, 9, 3, 1 }, 12)]
        [InlineData(new int[] { 8, 2, 8, 9, 2 }, 18)]
        public void Rob_ShouldReturn_MaximumAmount_ThatCanBeRobbed(int[] nums, int expectedAmount)
        {
            // Arrange
            var houseRobber = new HouseRobber();

            // Act
            var amount = houseRobber.Rob(nums);

            // Assert
            amount.Should().Be(expectedAmount);
        }
    }
}
