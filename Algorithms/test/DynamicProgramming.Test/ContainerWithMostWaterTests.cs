namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class ContainerWithMostWaterTests
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 2, 1, 4 }, 16)]
        [InlineData(new int[] { 1, 2, 1 }, 2)]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        public void MaxArea_ShouldReturn_MaximumAreaBetweenTwoLines(
            int[] heights,
            int expectedMaximumArea)
        {
            // Arrange
            var container = new ContainerWithMostWater();

            // Act
            var maximumArea = container.MaxArea(heights);

            // Assert
            maximumArea.Should().Be(expectedMaximumArea);
        }
    }
}
