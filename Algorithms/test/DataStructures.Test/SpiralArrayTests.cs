namespace DataStructures.Test
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    public class SpiralArrayTests
    {
        [Fact]
        public void GetClockwiseSpiral_ShouldReturn_ClockwiseSpiralOf_1x6_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4, 5, 6 }
            };

            var expectedSpiralArray = new List<int>
            {
                1, 2, 3, 4, 5, 6
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetClockwiseSpiral_ShouldReturn_ClockwiseSpiralOf_3x2_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6 }
            };

            var expectedSpiralArray = new List<int>
            {
                1, 2,
                4, 6,
                5,
                3
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetClockwiseSpiral_ShouldReturn_ClockwiseSpiralOf_4x4_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4 },
                new List<int> { 5, 6, 7, 8 },
                new List<int> { 9, 10, 11, 12 },
                new List<int> { 13, 14, 15, 16 }
            };

            var expectedSpiralArray = new List<int>
            {
                1, 2, 3, 4,
                8, 12, 16,
                15, 14, 13,
                9, 5,
                6, 7,
                11,
                10
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetClockwiseSpiral_ShouldReturn_ClockwiseSpiralOf_5x6_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4, 5, 6 },
                new List<int> { 7, 8, 9, 10, 11, 12 },
                new List<int> { 13, 14, 15, 16, 17, 18 },
                new List<int> { 19, 20, 21, 22, 23, 24 },
                new List<int> { 25, 26, 27, 28, 29, 30 }
            };

            var expectedSpiralArray = new List<int>
            {
                1, 2, 3, 4, 5, 6,
                12, 18, 24, 30,
                29, 28, 27, 26, 25,
                19, 13, 7,
                8, 9, 10, 11,
                17, 23,
                22, 21, 20,
                14,
                15, 16
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetClockwiseSpiral_ShouldReturn_ClockwiseSpiralOf_7x9_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18 },
                new List<int> { 19, 20, 21, 22, 23, 24, 25, 26, 27 },
                new List<int> { 28, 29, 30, 31, 32, 33, 34, 35, 36 },
                new List<int> { 37, 38, 39, 40, 41, 42, 43, 44, 45 },
                new List<int> { 46, 47, 48, 49, 50, 51, 52, 53, 54 },
                new List<int> { 55, 56, 57, 58, 59, 60, 61, 62, 63 }
            };

            var expectedSpiralArray = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                18, 27, 36, 45, 54, 63,
                62, 61, 60, 59, 58, 57, 56, 55,
                46, 37, 28, 19, 10,
                11, 12, 13, 14, 15, 16, 17,
                26, 35, 44, 53,
                52, 51, 50, 49, 48, 47,
                38, 29, 20,
                21, 22, 23, 24, 25,
                34, 43,
                42, 41, 40, 39,
                30,
                31, 32, 33
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetAntiClockwiseSpiral_ShouldReturn_AntiClockwiseSpiralOf_1x6_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4, 5, 6 }
            };

            var expectedSpiralArray = new List<int>
            {
                6, 5, 4, 3, 2, 1
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetAntiClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetAntiClockwiseSpiral_ShouldReturn_AntiClockwiseSpiralOf_3x2_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6 }
            };

            var expectedSpiralArray = new List<int>
            {
                2, 1,
                3, 5,
                6,
                4
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetAntiClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetAntiClockwiseSpiral_ShouldReturn_AntiClockwiseSpiralOf_4x4_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4 },
                new List<int> { 5, 6, 7, 8 },
                new List<int> { 9, 10, 11, 12 },
                new List<int> { 13, 14, 15, 16 }
            };

            var expectedSpiralArray = new List<int>
            {
                4, 3, 2, 1,
                5, 9, 13,
                14, 15, 16,
                12, 8,
                7, 6,
                10,
                11
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetAntiClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }

        [Fact]
        public void GetAntiClockwiseSpiral_ShouldReturn_AntiClockwiseSpiralOf_5x6_JaggedList()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4, 5, 6 },
                new List<int> { 7, 8, 9, 10, 11, 12 },
                new List<int> { 13, 14, 15, 16, 17, 18 },
                new List<int> { 19, 20, 21, 22, 23, 24 },
                new List<int> { 25, 26, 27, 28, 29, 30 }
            };

            var expectedSpiralArray = new List<int>
            {
                6, 5, 4, 3, 2, 1,
                7, 13, 19, 25,
                26, 27, 28, 29, 30,
                24, 18, 12,
                11, 10, 9, 8,
                14, 20,
                21, 22, 23,
                17, 16, 15
            };

            var spiralArray = new SpiralArray();

            // Act
            var spiraledArray = spiralArray.GetAntiClockwiseSpiral(numbers);

            // Assert
            spiraledArray.Should().BeEquivalentTo(expectedSpiralArray);
        }
    }
}
