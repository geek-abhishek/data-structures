namespace DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class TreeNode
    {
        public int Val { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public TreeNode(int x)
        {
            Val = x;
        }
    }

    public class KDistantNodesInBinaryTree
    {
        private readonly IList<TreeNode> queue = new List<TreeNode>();
        private int first = -1;

        private readonly Dictionary<int, int> visitedNodes = new Dictionary<int, int>();

        public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            if (root == null || target == null)
            {
                return null;
            }

            if (K == 0)
            {
                return new List<int> { target.Val };
            }

            this.visitedNodes.Add(target.Val, 0);

            this.DiscoverLevelNodes(root, target, K);

            return this.visitedNodes
                .Where(item => item.Value == K)
                .Select(item => item.Key)
                .ToList();
        }

        private TreeNode GetParent(TreeNode node, TreeNode parentNode, int val)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Val == val)
            {
                return parentNode;
            }

            var leftParent = this.GetParent(node.Left, node, val);
            var rightParent = this.GetParent(node.Right, node, val);

            return leftParent ?? rightParent;
        }

        private void GetLevelNodes(TreeNode root, TreeNode target, int level)
        {
            var left = target.Left;
            if (left != null && this.visitedNodes.ContainsKey(left.Val) == false)
            {
                this.AddToQueue(left);
                this.visitedNodes.Add(left.Val, level);
            }

            var right = target.Right;
            if (right != null && this.visitedNodes.ContainsKey(right.Val) == false)
            {
                this.AddToQueue(right);
                this.visitedNodes.Add(right.Val, level);
            }

            var parent = this.GetParent(root, null, target.Val);
            if (parent != null && this.visitedNodes.ContainsKey(parent.Val) == false)
            {
                this.AddToQueue(parent);
                this.visitedNodes.Add(parent.Val, level);
            }
        }

        private void DiscoverLevelNodes(TreeNode root, TreeNode target, int K)
        {
            int level = 1;
            if (this.first == this.queue.Count - 1)
            {
                // Queue is empty.
                this.GetLevelNodes(root, target, level);
            }

            while (this.GetFromQueue() != null)
            {
                this.GetLevelNodes(
                    root, this.GetFromQueue(),
                    this.visitedNodes[this.GetFromQueue().Val] + 1);
                
                this.RemoveFromQueue();
            }
        }

        private TreeNode GetFromQueue()
        {
            if (this.queue.Count == 0)
            {
                return null;
            }

            if (first >= this.queue.Count)
            {
                return null;
            }

            return this.queue[first];
        }

        private void AddToQueue(TreeNode node)
        {
            if (this.queue.Count == 0)
            {
                this.first++;
            }

            this.queue.Add(node);
        }

        private void RemoveFromQueue()
        {
            this.first++;
        }
    }
}
