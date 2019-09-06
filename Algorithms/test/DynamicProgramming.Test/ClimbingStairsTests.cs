namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class ClimbingStairsTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(6, 13)]
        [InlineData(27, 317811)]
        public void GetNumberOfWays_ShouldReturn_NumberOfWaysTheStairsCouldBeClimbed(
            int numberOfStairs,
            int expectedNumberOfWays)
        {
            // Arrange
            var climbingStairs = new ClimbingStairs();

            // Act
            var numberOfWays = climbingStairs.GetNumberOfWays(numberOfStairs);

            // Assert
            numberOfWays.Should().Be(expectedNumberOfWays);
        }
    }
}
