namespace DynamicProgramming
{
    using System;

    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maximumArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                var distance = 1;
                for (int j = 0; j < height.Length; j++)
                {
                    if (j <= i)
                    {
                        continue;
                    }

                    var area = Math.Min(height[i], height[j]) * distance;
                    if (area > maximumArea)
                    {
                        maximumArea = area;
                    }

                    distance++;
                }
            }

            return maximumArea;
        }
    }
}
