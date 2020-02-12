namespace DynamicProgramming
{
    public class UniquePaths
    {
        public int GetUniquePaths(int m, int n)
        {
            var pathArray = new int[m, n];
            pathArray[0, 0] = 1;

            for (int i = 1; i < m; i++)
            {
                pathArray[i, 0] = 1;
            }

            for (int j = 1; j < n; j++)
            {
                pathArray[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    pathArray[i, j] = pathArray[i - 1, j] + pathArray[i, j - 1];
                }
            }

            return pathArray[m - 1, n - 1];
        }

        // ToDo: To be further optimized on memory usage
        // ToDo: To be unit tested
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            if (obstacleGrid[0][0].Equals(1))
            {
                return 0;
            }

            if (m.Equals(1) && n.Equals(1))
            {
                if (obstacleGrid[0][0].Equals(0))
                {
                    return 1;
                }
                return 0;
            }

            var pathArray = new int[m, n];
            pathArray[0, 0] = 1;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    pathArray[i, j] = 0;
                }
            }

            for (int i = 1; i < m; i++)
            {
                if (obstacleGrid[i][0].Equals(1))
                {
                    pathArray[i, 0] = 0;
                    break;
                }
                else
                {
                    pathArray[i, 0] = 1;
                }
            }

            for (int j = 1; j < n; j++)
            {
                if (obstacleGrid[0][j].Equals(1))
                {
                    pathArray[0, j] = 0;
                    break;
                }
                else
                {
                    pathArray[0, j] = 1;
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j].Equals(1))
                    {
                        pathArray[i, j] = 0;
                    }
                    else
                    {
                        pathArray[i, j] = pathArray[i - 1, j] + pathArray[i, j - 1];
                    }
                }
            }

            return pathArray[m - 1, n - 1];
        }
    }
}
