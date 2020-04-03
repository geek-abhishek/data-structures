namespace DataStructures
{
    using System;
    using System.Collections.Generic;

    public class BinaryTree
    {
        public int Data { get; set; }

        public BinaryTree Left { get; set; }

        public BinaryTree Right { get; set; }

        public int Level { get; set; }

        public BinaryTree(int data)
        {
            this.Data = data;
            this.Left = this.Right = null;
            this.Level = 0;
        }

        public void AddLeft(BinaryTree subtree)
        {
            this.Left = subtree;
            this.Left.Level = this.Level + 1;
        }

        public void AddRight(BinaryTree subtree)
        {
            this.Right = subtree;
            this.Right.Level = this.Level + 1;
        }
    }

    public class BinaryTreeTraversal
    {
        public List<int> DepthTraversal(BinaryTree tree, List<int> traversed = null)
        {
            if (traversed == null)
            {
                traversed = new List<int>();
            }

            traversed.Add(tree.Data);

            if (tree.Left == null && tree.Right == null)
            {
                return traversed;
            }

            if (tree.Left != null)
            {
                this.DepthTraversal(tree.Left, traversed);
            }

            if (tree.Right != null)
            {
                this.DepthTraversal(tree.Right, traversed);
            }

            return traversed;
        }

        public List<int> BreadthTraversal(BinaryTree tree)
        {
            var height = this.GetHeight(tree);
            var traversed = new List<int>();

            for (int i = 0; i < height; i++)
            {
                this.BreadthTraversal(tree, i, traversed);
            }

            return traversed;
        }

        private int GetHeight(BinaryTree tree)
        {
            if (tree == null)
            {
                return 0;
            }

            return Math.Max(
                this.GetHeight(tree.Left),
                this.GetHeight(tree.Right)) + 1;
        }

        private List<int> BreadthTraversal(BinaryTree tree, int level, List<int> traversed)
        {
            if (tree == null)
            {
                return traversed;
            }

            if (level == 0)
            {
                traversed.Add(tree.Data);
            }
            else if (level > 0)
            {
                this.BreadthTraversal(tree.Left, level - 1, traversed);
                this.BreadthTraversal(tree.Right, level - 1, traversed);
            }

            return traversed;
        }
    }
}
