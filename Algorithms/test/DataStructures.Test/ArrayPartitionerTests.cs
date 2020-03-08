namespace DataStructures.Test
{
    using FluentAssertions;
    using Xunit;

    public class ArrayPartitionerTests
    {
        [Theory]
        [InlineData(new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 }, true)]
        [InlineData(new int[] { 0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 }, false)]
        [InlineData(new int[] { 2, 8, 15, -5, 0, 9, -3, 4 }, true)]
        public void CanBePartitioned_ShouldReturn_WhetherArrayCanBePartitioned_IntoThreeSubarraysWithEqualSum(
            int[] A, bool expectedResult)
        {
            // Arrange
            var arrayPartitioner = new ArrayPartitioner();

            // Act
            var result = arrayPartitioner.CanBePartitioned(A);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
