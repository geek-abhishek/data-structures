namespace DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class SpiralArray
    {
        public List<int> GetClockwiseSpiral(List<List<int>> numbers)
        {
            var spiral = new List<int>();

            if (numbers == null
                || numbers.Any() == false
                || numbers.FirstOrDefault() == null)
            {
                return spiral;
            }

            var rowCount = numbers.Count;
            var columnCount = numbers.FirstOrDefault().Count;
            var elementCount = rowCount * columnCount;

            if (rowCount.Equals(1))
            {
                return numbers.FirstOrDefault();
            }

            var rowStartIndex = 0;
            var columnStartIndex = 0;
            var rowEndIndex = rowCount - 1;
            var columnEndIndex = columnCount - 1;

            while (spiral.Count < elementCount)
            {
                spiral.AddRange(this.GoRight(
                    numbers: numbers,
                    rowNumber: rowStartIndex,
                    start: rowStartIndex,
                    end: columnEndIndex));

                spiral.AddRange(this.GoDown(
                    numbers: numbers,
                    columnNumber: columnEndIndex,
                    start: rowStartIndex + 1,
                    end: rowEndIndex));

                spiral.AddRange(this.GoLeft(
                    numbers: numbers,
                    rowNumber: rowEndIndex,
                    start: columnEndIndex - 1,
                    end: rowStartIndex));

                spiral.AddRange(this.GoUp(
                    numbers: numbers,
                    columnNumber: columnStartIndex,
                    start: rowEndIndex - 1,
                    end: rowStartIndex + 1));

                ++rowStartIndex;
                ++columnStartIndex;
                --rowEndIndex;
                --columnEndIndex;
            }

            return spiral.Skip(0).Take(elementCount).ToList();
        }

        public List<int> GetAntiClockwiseSpiral(List<List<int>> numbers)
        {
            var spiral = new List<int>();

            if (numbers == null
                || numbers.Any() == false
                || numbers.FirstOrDefault() == null)
            {
                return spiral;
            }

            var rowCount = numbers.Count;
            var columnCount = numbers.FirstOrDefault().Count;
            var elementCount = rowCount * columnCount;

            if (rowCount.Equals(1))
            {
                numbers.FirstOrDefault().Reverse();
                return numbers.FirstOrDefault();
            }

            var rowStartIndex = 0;
            var columnStartIndex = 0;
            var rowEndIndex = rowCount - 1;
            var columnEndIndex = columnCount - 1;

            while (spiral.Count < elementCount)
            {
                spiral.AddRange(this.GoLeft(
                    numbers: numbers,
                    rowNumber: rowStartIndex,
                    start: columnEndIndex,
                    end: rowStartIndex));

                spiral.AddRange(this.GoDown(
                    numbers: numbers,
                    columnNumber: columnStartIndex,
                    start: rowStartIndex + 1,
                    end: rowEndIndex));

                spiral.AddRange(this.GoRight(
                    numbers: numbers,
                    rowNumber: rowEndIndex,
                    start: columnStartIndex + 1,
                    end: columnEndIndex));

                spiral.AddRange(this.GoUp(
                    numbers: numbers,
                    columnNumber: columnEndIndex,
                    start: rowEndIndex - 1,
                    end: rowStartIndex + 1));

                ++rowStartIndex;
                ++columnStartIndex;
                --rowEndIndex;
                --columnEndIndex;
            }

            return spiral.Skip(0).Take(elementCount).ToList();
        }

        private List<int> GoRight(
            List<List<int>> numbers,
            int rowNumber,
            int start,
            int end)
        {
            var traversal = new List<int>();

            for (var i = start; i <= end; i++)
            {
                traversal.Add(numbers[rowNumber][i]);
            }

            return traversal;
        }

        private List<int> GoDown(
            List<List<int>> numbers,
            int columnNumber,
            int start,
            int end)
        {
            var traversal = new List<int>();

            for (var i = start; i <= end; i++)
            {
                traversal.Add(numbers[i][columnNumber]);
            }

            return traversal;
        }

        private List<int> GoLeft(
            List<List<int>> numbers,
            int rowNumber,
            int start,
            int end)
        {
            var traversal = new List<int>();

            for (var i = start; i >= end; i--)
            {
                traversal.Add(numbers[rowNumber][i]);
            }

            return traversal;
        }

        private List<int> GoUp(
            List<List<int>> numbers,
            int columnNumber,
            int start,
            int end)
        {
            var traversal = new List<int>();

            for (var i = start; i >= end; i--)
            {
                traversal.Add(numbers[i][columnNumber]);
            }

            return traversal;
        }
    }
}
