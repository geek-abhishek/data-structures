namespace SortingAlgorithms.Test
{
    using FluentAssertions;
    using Xunit;

    public class HeapSortTests
    {
        [Theory]
        [InlineData(new int[] { 30, 10, 20, 50, 60, 40, 70 }, new int[] { 10, 20, 30, 40, 50, 60, 70 })]
        [InlineData(new int[] { 48, 23, 15, 90, 46, 87, 53, 61, 35, 79, 19 }, new int[] { 15, 19, 23, 35, 46, 48, 53, 61, 79, 87, 90 })]
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
