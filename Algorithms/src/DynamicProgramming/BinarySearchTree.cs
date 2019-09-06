namespace DynamicProgramming
{
    public class BinarySearchTree
    {
        public int GetUniqueTreesCount(int n)
        {
            if (n.Equals(0))
            {
                return 0;
            }

            var treeCount = new int[n + 1];
            treeCount[0] = 1;
            treeCount[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                treeCount[i] = 0;
                for (int j = 1; j <= i; j++)
                {
                    treeCount[i] += (treeCount[i - j] * treeCount[j - 1]);
                }
            }

            return treeCount[n];
        }
    }
}
