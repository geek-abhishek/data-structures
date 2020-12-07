namespace DynamicProgramming.Test
{
    using FluentAssertions;
    using Xunit;

    public class DiceRollWithTargetSumTests
    {
        [Theory]
        [InlineData(1, 2, 3, 0)]
        [InlineData(2, 6, 7, 6)]
        [InlineData(3, 6, 8, 21)]
        [InlineData(2, 5, 10, 1)]
        [InlineData(30, 30, 500, 222616187)]
        public void NumRollsToTarget_ShouldReturn_NumberOfWaysInWhichSumCanBeAchieved(
            int numberOfDices,
            int numberofFaces,
            int sumToAchieve,
            int expectedNumberOfWays)
        {
            // Arrange
            var diceRoll = new DiceRollWithTargetSum();

            // Act
            var numberOfWays = diceRoll.NumRollsToTarget(
                numberOfDices,
                numberofFaces,
                sumToAchieve);

            // Assert
            numberOfWays.Should().Be(expectedNumberOfWays);
        }
    }
}
