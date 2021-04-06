namespace DataStructures.Test
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class MaximumTreeDepthTests
    {
        [Fact]
        public void GetMaximumDepth_ShouldReturn_MaximumDepth_OfCombinedTree()
        {
            // Arrange
            var subtrees = new List<List<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 2, 3, 4 },
                new List<int> { 4, 5 },
                new List<int> { 6, 7 },
                new List<int> { 7, 8, 9 },
                new List<int> { 10, 11, 12 }
            };
            var expectedResult = 4;

            var maximumTreeDepth = new MaximumTreeDepth();

            // Act
            var result = maximumTreeDepth.GetMaximumDepth(subtrees);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
