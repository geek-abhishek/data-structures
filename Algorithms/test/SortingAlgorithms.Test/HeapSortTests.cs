namespace SortingAlgorithms.Test
{
    using FluentAssertions;
    using Xunit;

    public class HeapSortTests
    {
        [Theory]
        [InlineData(new int[] { 30, 10, 20, 50, 60, 40, 70 }, new int[] { 10, 20, 30, 40, 50, 60, 70 })]
        public void ArrangeInAscending_ShouldSort_TheNumbers_InAscendingOrder(
            int[] numbers,
            int[] expectedSortedNumbers)
        {
            // Arrange
            var heapSort = new HeapSort();

            // Act
            var sortedNumbers = heapSort.ArrangeInAscending(numbers);

            // Assert
            expectedSortedNumbers.Should().BeEquivalentTo(sortedNumbers);
        }
    }
}
