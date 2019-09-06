namespace DynamicProgramming
{
    public class ClimbingStairs
    {
        public int GetNumberOfWays(int n)
        {
            if (n < 2)
            {
                return n;
            }

            int[] fibonacci = new int[n + 1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            fibonacci[2] = 2;

            for (var i = 3; i <= n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci[n];
        }
    }
}
