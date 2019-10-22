namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class MinimumPathTriangleTests
    {
        [Fact]
        public void GetMinimumPath_ShouldReturn_SumOfMinimumElementsFromEveryLevel()
        {
            // Arrange
            var triangle = new List<IList<int>>
            {
                new List<int> { -1 },
                new List<int> { 2, 3 },
                new List<int> { 1, -1, -3 }
            };
            var expectedMinimumSumOfPath = -1;

            var minimumPathTriangle = new MinimumPathTriangle();

            // Act
            var minimumSumOfPath = minimumPathTriangle.GetMinimumPath(triangle);
 
            // Assert
            minimumSumOfPath.Should().Be(expectedMinimumSumOfPath);

            // Arrange
            triangle.Clear();
            triangle.AddRange(new List<IList<int>>
            {
                new List<int> { 2 },
                new List<int> { 3, 4 },
                new List<int> { 6, 5, 7 },
                new List<int> { 4, 1, 8, 3 }
            });
            expectedMinimumSumOfPath = 11;

            // Act
            minimumSumOfPath = minimumPathTriangle.GetMinimumPath(triangle);

            // Assert
            minimumSumOfPath.Should().Be(expectedMinimumSumOfPath);
        }
    }
}
