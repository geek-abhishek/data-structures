namespace DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumTreeDepth
    {
        private readonly Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        private readonly HashSet<int> visited = new HashSet<int>();

        public int GetMaximumDepth(List<List<int>> subtrees)
        {
            for (int i = 0; i < subtrees.Count; i++)
            {
                if (subtrees[i].Count == 0)
                {
                    continue;
                }

                map.Add(subtrees[i][0], new List<int>());
                for (int j = 1; j < subtrees[i].Count; j++)
                {
                    map[subtrees[i][0]].Add(subtrees[i][j]);
                }
            }

            var depths = new List<int>();
            for (int i = 0; i < map.Count; i++)
            {
                var root = map.Keys.ToList()[i];
                if (visited.Contains(root))
                {
                    continue;
                }

                visited.Add(root);
                depths.Add(GetDepth(root));
            }

            var maximum = depths[0];
            for (int i = 1; i < depths.Count; i++)
            {
                if (depths[i] > maximum)
                {
                    maximum = depths[i];
                }
            }

            return maximum;
        }

        private int GetDepth(int root)
        {
            if (map.ContainsKey(root) == false)
            {
                return 1;
            }

            if (map[root].Count == 0)
            {
                return 1;
            }

            var tree = map[root];
            var result = 0;
            for (int i = 0; i < tree.Count; i++)
            {
                if (visited.Contains(tree[i]))
                {
                    continue;
                }

                visited.Add(tree[i]);
                result = 1 + GetDepth(tree[i]);
            }

            return result;
        }
    }
}
