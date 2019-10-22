namespace DynamicProgramming
{
    using System;

    public class OptimalRectangle
    {
        public int[] ConstructRectangle(int area)
        {
            var areaRoot = (int)Math.Sqrt(area);
            if (Math.Pow(areaRoot, 2).Equals(area))
            {
                return new int[] { areaRoot, areaRoot };
            }

            for (int i = (areaRoot + 1); i < area; i++)
            {
                if ((area % i).Equals(0))
                {
                    return new int[] { i, area / i };
                }
            }

            return new int[] { area, 1 };
        }
    }
}
