namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class WordSearchTests
    {
        [Fact]
        public void Exist_ShouldReturn_WhetherTheWordExists()
        {
            // Arrange
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' },
            };
            var word = "ABCCED";
            var expectedResult = true;

            var wordSearch = new WordSearch();

            // Act
            var result = wordSearch.Exist(board, word);

            // Assert
            result.Should().Be(expectedResult);

            // Arrange
            board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' },
            };
            word = "SEE";
            expectedResult = true;

            wordSearch = new WordSearch();

            // Act
            result = wordSearch.Exist(board, word);

            // Assert
            result.Should().Be(expectedResult);

            // Arrange
            board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' },
            };
            word = "ABCB";
            expectedResult = false;

            wordSearch = new WordSearch();

            // Act
            result = wordSearch.Exist(board, word);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
