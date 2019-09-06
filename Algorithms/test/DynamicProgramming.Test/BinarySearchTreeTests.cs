namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class BinarySearchTreeTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(6, 132)]
        [InlineData(19, 1767263190)]
        public void GetUniqueTreesCount_ShouldReturn_CountOfUniqueBinarySearchTrees(
            int n,
            int expectedUniqueTreesCount)
        {
            // Arrange
            var binarySearchTree = new BinarySearchTree();

            // Act
            var uniqueTreesCount = binarySearchTree.GetUniqueTreesCount(n);

            // Assert
            uniqueTreesCount.Should().Be(expectedUniqueTreesCount);
        }
    }
}
