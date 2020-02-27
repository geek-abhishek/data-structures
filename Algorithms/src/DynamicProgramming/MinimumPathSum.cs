namespace DynamicProgramming
{
    public class MinimumPathSum
    {
        public int GetMinimumSum(int[][] grid)
        {
            var pathGrid = new int[grid.Length][];
            pathGrid[0] = new int[grid[0].Length];
            pathGrid[0][0] = grid[0][0];

            for (var i = 1; i < grid.Length; i++)
            {
                pathGrid[i] = new int[grid[i].Length];
                pathGrid[i][0] = grid[i][0] + GetElement(pathGrid, i - 1, 0);
            }

            for (var i = 1; i < grid[0].Length; i++)
            {
                pathGrid[0][i] = grid[0][i] + GetElement(pathGrid, 0, i - 1);
            }

            for (int i = 1; i < grid.Length; i++)
            {
                for (int j = 1; j < grid[i].Length; j++)
                {
                    pathGrid[i][j] = GetMinimum(
                        grid[i][j] + GetElement(pathGrid, i, j - 1),
                        grid[i][j] + GetElement(pathGrid, i - 1, j));
                }
            }

            return pathGrid[grid.Length - 1][pathGrid[grid.Length - 1].Length - 1];
        }

        private int GetElement(int[][] pathGrid, int row, int col)
        {
            if (row < 0)
            {
                return 0;
            }

            if (col < 0)
            {
                return 0;
            }

            return pathGrid[row][col];
        }

        private int GetMinimum(int element1, int element2) =>
            element1 < element2 ? element1 : element2;
    }
}
