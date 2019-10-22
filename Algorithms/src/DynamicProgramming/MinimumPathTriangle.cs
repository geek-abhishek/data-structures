namespace DynamicProgramming
{
    using System;
    using System.Collections.Generic;

    public class MinimumPathTriangle
    {
        public int GetMinimumPath(IList<IList<int>> triangle)
        {
            int[] minimumPathSum = new int[triangle.Count];
            int n = triangle.Count - 1;

            for (int i = 0; i < triangle[n].Count; i++)
            {
                minimumPathSum[i] = triangle[n][i];
            }

            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i + 1].Count - 1; j++)
                {
                    minimumPathSum[j] = triangle[i][j] + Math.Min(minimumPathSum[j], minimumPathSum[j + 1]);
                }
            }

            return minimumPathSum[0];
        }
    }
}
