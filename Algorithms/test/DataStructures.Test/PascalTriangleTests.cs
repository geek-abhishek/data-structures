namespace DataStructures.Test
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class PascalTriangleTests
    {
        [Fact]
        public void GenerateTriangle_ShouldReturn_PascalTriangle_ForGivenRows()
        {
            // Arrange
            var numRows = 5;
            var expectedTriangle = new List<IList<int>>
            {
                new List<int> { 1 },
                new List<int> { 1, 1 },
                new List<int> { 1, 2, 1 },
                new List<int> { 1, 3, 3, 1 },
                new List<int> { 1, 4, 6, 4, 1 }
            };

            var pascalTriangle = new PascalTriangle();

            // Act
            var triangle = pascalTriangle.GenerateTriangle(numRows);

            // Assert
            triangle.Should().BeEquivalentTo(expectedTriangle);
        }

        [Fact]
        public void GetRow_ShouldReturn_PascalTriangleRow_ForGivenRowIndex()
        {
            // Arrange
            var rowIndex = 3;
            var expectedRow = new List<int> { 1, 3, 3, 1 };

            var pascalTriangle = new PascalTriangle();

            // Act
            var row = pascalTriangle.GetRow(rowIndex);

            // Assert
            row.Should().BeEquivalentTo(expectedRow);
        }
    }
}
