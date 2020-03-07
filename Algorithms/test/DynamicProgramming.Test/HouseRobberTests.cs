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
        [InlineData(new int[] { 183, 219, 57, 193, 94, 233, 202, 154, 65, 240, 97, 234, 100, 249, 186, 66, 90, 238, 168, 128, 177, 235, 50, 81, 185, 165, 217, 207, 88, 80, 112, 78, 135, 62, 228, 247, 211 }, 3365)]
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
