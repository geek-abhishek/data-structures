namespace DataStructures
{
    using System.Collections.Generic;

    public class PascalTriangle
    {
        public IList<IList<int>> GenerateTriangle(int numRows)
        {
            var triangle = new List<IList<int>>();

            if (numRows.Equals(0))
            {
                return triangle;
            }

            triangle.Add(new List<int> { 1 });

            if (numRows.Equals(1))
            {
                return triangle;
            }

            triangle.Add(new List<int> { 1, 1 });

            for (var i = 2; i < numRows; i++)
            {
                var row = new List<int> { 1 };

                for (int j = 1; j < i; j++)
                {
                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                }

                row.Add(1);
                triangle.Add(row);
            }

            return triangle;
        }

        public IList<int> GetRow(int rowIndex)
        {
            var triangle = new List<IList<int>>
            {
                new List<int> { 1 }
            };

            if (rowIndex.Equals(0))
            {
                return triangle[0];
            }

            triangle.Add(new List<int> { 1, 1 });

            for (var i = 2; i <= rowIndex; i++)
            {
                var row = new List<int> { 1 };

                for (int j = 1; j < i; j++)
                {
                    row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                }

                row.Add(1);
                triangle.Add(row);
            }

            return triangle[rowIndex];
        }
    }
}
