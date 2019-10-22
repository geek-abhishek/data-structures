namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class OptimalRectangleTests
    {
        [Theory]
        [InlineData(1, new int[] { 1, 1 })]
        [InlineData(12, new int[] { 4, 3 })]
        [InlineData(100, new int[] { 10, 10 })]
        public void ConstructRectangle_ShouldContruct_AnOptimalRectangle_ForGivenArea(
            int area,
            int[] expectedSides)
        {
            // Arrange
            var optimalRectangle = new OptimalRectangle();

            // Act
            var sides = optimalRectangle.ConstructRectangle(area);

            // Assert
            sides.Should().BeEquivalentTo(expectedSides);
        }
    }
}
